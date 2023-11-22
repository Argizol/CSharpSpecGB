using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.Seminar8
{
    internal class HW8
    {
        public static IEnumerable<string> SerchFilesByExtension(string path)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories);
            return files;
        }
    }
}

