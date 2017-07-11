using System.IO;
namespace TlvProto
{
    interface ITlvSerialisable
    {
        void Serialise(Stream s);
    }
}
