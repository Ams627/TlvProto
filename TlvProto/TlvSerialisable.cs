using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace TlvProto
{
    partial class TlvSerialisable : ITlvSerialisable
    {
        static (bool ok, int length, uint result) ConvertToTlv(int input)
        {
            return ConvertToTlv((uint)input);
        }

        static (bool ok, int length, uint result) ConvertToTlv(uint input)
        {
            bool ok = true;
            uint output = 0;
            int length = 0;

            if (input > 0x1FFF_FFFF)
            {
                ok = false;
            }
            if (ok)
            {
                if (input > 0x1F_FFFF)
                {
                    length = 4;
                    output = input | 0xC0000000;
                }
                else if (input > 0x1FFF)
                {
                    length = 3;
                    output = input | 0xA00000;
                }
                else if (input > 0x7F)
                {
                    length = 2;
                    output = input | 0x8000;
                }
                else
                {
                    length = 1;
                    output = input & 0x7F;
                }
            }
            return (ok, length, output);
        }

        static (bool ok, int length, UInt64 result) ConvertToTlv(UInt64 input)
        {
            bool ok = true;
            UInt64 output = 0;
            int length = 0;

            if (input > 0x1FFF_FFFF && input <= 0x1F_FFFF_FFFF) 
            {
                length = 5;
                output = input;
                output |= 0xE000000000;
            }
            if (output == 0)
            {
                if (input > 0x1F_FFFF)
                {
                    length = 4;
                    output = input | 0xC0000000;
                }
                else if (input > 0x1FFF)
                {
                    length = 3;
                    output = input | 0xA00000;
                }
                else if (input > 0x7F)
                {
                    length = 2;
                    output = input | 0x8000;
                }
                else
                {
                    length = 1;
                    output = input & 0x7F;
                }
            }
            return (ok, length, output);
        }


        static void AddIntToStream(Stream s, uint i, int length)
        {
            if (length > 3)
            {
                s.WriteByte((byte)((i >> 24) & 0xFF));
            }
            if (length > 2)
            {
                s.WriteByte((byte)((i >> 16) & 0xFF));
            }
            if (length > 1)
            {
                s.WriteByte((byte)((i >> 8) & 0xFF));
            }
            s.WriteByte((byte)(i & 0xFF));
        }

        static void AddIntToStream(Stream s, UInt64 i, int length)
        {
            if (length > 4)
            {
                s.WriteByte((byte)((i >> 32) & 0xFF));
            }
            if (length > 3)
            {
                s.WriteByte((byte)((i >> 24) & 0xFF));
            }
            if (length > 2)
            {
                s.WriteByte((byte)((i >> 16) & 0xFF));
            }
            if (length > 1)
            {
                s.WriteByte((byte)((i >> 8) & 0xFF));
            }
            s.WriteByte((byte)(i & 0xFF));
        }

        public void Serialise(Stream s)
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (Attribute.IsDefined(property, typeof(TlvAttribute)))
                {
                    var attribute = (TlvAttribute)property.GetCustomAttribute(typeof(TlvAttribute));
                    var tag = attribute.Tag;
                    var module = attribute.Module;
                    var name = property.Name;
                    var value = property.GetValue(this);
                    var type = attribute.Type;

                    tag |= 0x4000;

                    if (type == TlvTypes.Array)
                    {
                        module |= 0x80;
                        tag |= 0x8000;
                    }

                    s.WriteByte((byte)(module & 0xFF));
                    s.WriteByte((byte)((tag >> 8) & 0xFF));
                    s.WriteByte((byte)(tag & 0xFF));

                    if (type == TlvTypes.UInt || type == TlvTypes.Int)
                    {
                        var tlv = ConvertToTlv((uint)(int)value);
                        s.WriteByte((byte)(tlv.length + 1));
                        s.WriteByte((byte)type);
                        AddIntToStream(s, tlv.result, tlv.length);
                    }
                    else if (type == TlvTypes.String)
                    {
                        var str = value.ToString();
                        // add the length of the string to the output stream:
                        var tlv = ConvertToTlv(str.Length + 1);
                        AddIntToStream(s, tlv.result, tlv.length);
                        s.WriteByte((byte)TlvTypes.String);
                        foreach (var c in str)
                        {
                            s.WriteByte((byte)c);
                        }
                    }
                    else if (type == TlvTypes.Date)
                    {
                        bool isEndDate = Attribute.IsDefined(property, typeof(TlvEndDateAttribute));
                        var date = (DateTime)value;
                        if (date.Year > 2999)
                        {
                            date = new DateTime(2999, 12, 31);
                        }
                        var seconds = (UInt64)(date - new DateTime(1970, 1, 1)).TotalSeconds;
                        // dates of 31-Dec-2999 always have the time component at 23:59:59
                        if (date.Date == new DateTime(2999, 12, 31).Date || isEndDate)
                        {
                            seconds += 3600 * 24 - 1;
                        }
                        var tlv = ConvertToTlv(seconds);
                        s.WriteByte((byte)(tlv.length + 1));
                        s.WriteByte((byte)TlvTypes.Date);
                        AddIntToStream(s, tlv.result, tlv.length);
                    }
                    else if (type == TlvTypes.Array)
                    {
                        var sequence = (IEnumerable)value;
                        if (sequence != null)
                        {
                            using (var tempStream = new MemoryStream())
                            {
                                foreach (var element in sequence)
                                {
                                    var serialisable = element as TlvSerialisable;

                                    using (var tempStream2 = new MemoryStream())
                                    {
                                        serialisable?.Serialise(tempStream2);
                                        var tlvInner = ConvertToTlv((uint)tempStream2.Length);
                                        AddIntToStream(tempStream, tlvInner.result, tlvInner.length);
                                        tempStream2.Position = 0;
                                        tempStream2.CopyTo(tempStream);
                                    }
                                }
                                var tlv = ConvertToTlv((UInt64)tempStream.Length);
                                AddIntToStream(s, tlv.result, tlv.length);
                                tempStream.Position = 0;
                                tempStream.CopyTo(s);
                            }
                        }
                    }
                }
            }
        }
    }
}
