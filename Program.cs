using CSharpSpecGB.Seminar5;
using CSharpSpecGB.seminar6;
using CSharpSpecGB.Seminar8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Channels;

class Program()
{
    static void Main(string[] args)
    {
        string path = "../../../"; 
        foreach (var file in HW8.SerchFilesByExtension(path))
        {
            Console.WriteLine(file);
        }

        Console.WriteLine();

        HW8.SerchTextInFiles(HW8.SerchFilesByExtension(path), "HW.8");
    }    
}



