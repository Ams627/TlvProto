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
                var m = new MemoryStream();
                var n = new S1();
                n.Serialise(m);
                using (var fs = new FileStream(@"c:\temp\fs1.txt", FileMode.Create, FileAccess.Write))
                {
                    byte[] header = new UTF8Encoding(true).GetBytes("TLtV0100");
                    fs.Write(header, 0, header.Length);
                    m.Position = 0;
                    m.CopyTo(fs);
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
