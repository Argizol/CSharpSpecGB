using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.Seminar8
{
    internal class HW8
    {
        public static IEnumerable<string> SerchFilesByExtension(string path)
        {
            return Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories);  
        }

        public static void SerchTextInFiles(IEnumerable<string> files, string serchText)
        {
            foreach (var file in files)
            {
                using (StreamReader sr = new(file))
                {
                    while (!sr.EndOfStream)
                    {
                        string? readedString = sr.ReadLine();
                        if (readedString is null)
                            continue;
                        if (readedString.Contains(serchText))
                            Console.WriteLine($"Текст {serchText} содрежится в файле: {file}");

                    }
                }
            }
        }
    }
}

