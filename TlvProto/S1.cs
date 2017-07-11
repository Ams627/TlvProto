using System;
using System.IO;
using System.Reflection;

namespace TlvProto
{
    partial class TlvSerialisable<T> : ITlvSerialisable
    {
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
        public void Serialise(Stream s)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (Attribute.IsDefined(property, typeof(TlvIntAttribute)))
                {
                    var attribute = (TlvIntAttribute)property.GetCustomAttribute(typeof(TlvIntAttribute));
                    var tag = attribute.Tag;
                    var module = attribute.Module;
                    var name = property.Name;
                    var value = (int)property.GetValue(this);

                    tag |= 0x4000;

                    s.WriteByte((byte)(module & 0xFF));
                    s.WriteByte((byte)((tag >> 8) & 0xFF));
                    s.WriteByte((byte)(tag & 0xFF));
                    var tlv = ConvertToTlv((uint)value);
                    s.WriteByte((byte)(tlv.length + 1));
                    s.WriteByte((byte)TlvTypeCodes.Int);
                    if (tlv.length > 3)
                    {
                        s.WriteByte((byte)((tlv.result >> 24) & 0xFF));
                    }
                    if (tlv.length > 2)
                    {
                        s.WriteByte((byte)((tlv.result >> 16) & 0xFF));
                    }
                    if (tlv.length > 1)
                    {
                        s.WriteByte((byte)((tlv.result >> 8) & 0xFF));
                    }
                    s.WriteByte((byte)(tlv.result & 0xFF));

                    if (s is MemoryStream)
                    {
                        byte[] ba = (s as MemoryStream).ToArray();
                        Console.WriteLine();
                    }

                    Console.WriteLine($"property name {name} value {value} tag {tag}");
                }
            }
        }
    }
    class S1 : TlvSerialisable<S1>
    {
        enum Wonk
        {
            Test = 1
        }
        [TlvInt((int)Wonk.Test)] public int Origin { get; set; } = 45;
        [TlvInt(6033)] public int Origin { get; set; } = 45;
    }
}
