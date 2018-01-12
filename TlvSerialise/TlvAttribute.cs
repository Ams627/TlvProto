namespace TlvSerialise
{
    public class TlvTest
    {

    }
    /// <summary>
    /// Add this attribute to a public property of a class to indicate a TLV field. The class must inherit from TLVSerialisable
    /// and the property will be serialised to TLV if this attribute is present on it.
    /// The precise representation depends on the type:
    ///      UInt = 1, String = 2, Time = 5, Date = 4, Int = 5, Binary = 6, Array = 32767
    /// For example to indicate a TLV Date field we do this:
    /// [Tlv(TlvTypes.Date, TlvTags.ID_PROD_FFL_END_DATE)] public DateTime EndDate { get; set; }
    /// To perform the serialisation simply call Serialise (present in the base class TLVSerialisable)
    /// </summary>
    public class TlvAttribute : System.Attribute
    {
        const int VenteModule = 6;
        private readonly int _tag;
        private readonly int _module;
        private readonly TlvTypes _type;

        public int Module => _module;
        public TlvTypes Type => _type;
        public int Tag => _tag;

        public TlvAttribute(TlvTypes type, TlvTags tag, int module = VenteModule)
        {
            _type = type;
            _tag = (int)tag;
            _module = module;
        }
        public TlvAttribute(TlvTypes type, int tag, int module = VenteModule)
        {
            _type = type;
            _tag = tag;
            _module = module;
        }
    }

    /// <summary>
    /// Add this attribute to indicate that a date only field is and end date. For end dates we will 
    /// add 24 * 3600 - 1 seconds to the tlv date (which is a number of seconds since midnight 1 Jan 1970
    /// </summary>
    public class TlvEndDateAttribute : System.Attribute
    {

    }
}