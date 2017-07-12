namespace TlvProto
{
    /// <summary>
    /// Add this attribute to a public property of a class to indicate a TLV field. The class must inherit from TLVSerialisable
    /// and the property will be serialised to TLV if this attribute is present on it.
    /// The precise representation depends on the type:
    ///      UInt = 1, String = 2, Time = 5, Date = 4, Int = 5, Binary = 6, Array = 32767
    /// For example to indicate a TLV Date field we do this:
    /// [Tlv(TlvTypes.Date, TlvTags.ID_PROD_FFL_END_DATE)] public DateTime EndDate { get; set; }
    /// To perform the serialisation simply call Serialise (present in the base class TLVSerialisable)
    /// </summary>
    class TlvAttribute : System.Attribute
    {
        const int VenteModule = 6;
        public int Tag { get; private set; }
        public int Module { get; private set; }
        public TlvTypes Type { get; set; }
        public TlvAttribute(TlvTypes type, TlvTags tag, int module = VenteModule)
        {
            Type = type;
            Tag = (int)tag;
            Module = module;
        }
        public TlvAttribute(TlvTypes type, int tag, int module = VenteModule)
        {
            Type = type;
            Tag = tag;
            Module = module;
        }
    }

    /// <summary>
    /// Add this attribute to indicate that a date only field is and end date. For end dates we will 
    /// add 24 * 3600 - 1 seconds to the tlv date (which is a number of seconds since midnight 1 Jan 1970
    /// </summary>
    class TlvEndDateAttribute : System.Attribute
    {

    }
}