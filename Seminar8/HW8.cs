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

        public static void SerchTextInFiles(IEnumerable<string> files, string serchText)
        {
           foreach(var file in files)
            {
                using(StreamReader sr = new(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string? readedString = sr.ReadLine();
                        if (readedString is null)
                            continue;
                        if(readedString.Contains(serchText))
                            Console.WriteLine($"Текст {serchText} содрежится в файле: {file}");

                    }
                }
            }
        }
    }
}

