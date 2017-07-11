namespace TlvProto
{
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

}
