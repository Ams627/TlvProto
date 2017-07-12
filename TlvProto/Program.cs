using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TlvProto
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var n = new Quicks();
                using (var fs = new FileStream(@"q:\temp\t1.tlv", FileMode.Create, FileAccess.Write))
                {
                    byte[] header = new UTF8Encoding(true).GetBytes("TLtV0100");
                    fs.Write(header, 0, header.Length);
                    n.Serialise(fs);
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
