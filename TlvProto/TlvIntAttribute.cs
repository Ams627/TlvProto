namespace TlvProto
{
    class TlvIntAttribute : System.Attribute
    {
        const int VenteModule = 6;
        public int Tag { get; private set; }
        public int Module { get; private set; } = VenteModule;
        public TlvIntAttribute(int tag)
        {
            Tag = tag;
        }
        public TlvIntAttribute(int module, int tag)
        {
            Tag = tag;
            Module = Module;
        }
    }

    class TlvStringAttribute : System.Attribute
    {
        const int VenteModule = 6;
        public int Tag { get; private set; }
        public int Module { get; private set; } = VenteModule;
        public TlvStringAttribute(int tag)
        {
            Tag = tag;
        }
        public TlvStringAttribute(int module, int tag)
        {
            Tag = tag;
            Module = Module;
        }
    }

    class TlvDateAttribute : System.Attribute
    {
        const int VenteModule = 6;
        public int Tag { get; private set; }
        public int Module { get; private set; } = VenteModule;
        public TlvDateAttribute(int tag)
        {
            Tag = tag;
        }
        public TlvDateAttribute(int module, int tag)
        {
            Tag = tag;
            Module = Module;
        }
    }

}
