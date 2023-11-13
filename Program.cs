using CSharpSpecGB.Seminar5;
using CSharpSpecGB.seminar6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Channels;

class Program()
{
    static void Main(string[] args)
    {
        Calc calc = new();
        calc.handler += SubscribeMyEvent;
        string exitCommand = String.Empty;
        string operation = String.Empty;
        string command = String.Empty;

        Console.WriteLine("Äîáðî ïîæàëîâàòü â ñòðàííûé êàëüêóëÿòîð ïî ñòðàííîìó çàäàíèþ");
        Console.WriteLine();

        while (true)
        {

            calc.ExecuteOperation();

            Console.WriteLine("Ïðîäîëæèòü ðàáîòó?");
            Console.Write("Äëÿ çàâåðøåíèÿ ðàáîòû ââåäèòå:" +
                " Îòìåíà èëè ïîñòàâüòå ïðîáåë è íàæìèòå Enter\n" +
                "Äëÿ ïðîäîëæåíèÿ ðàáîòû íàæìèòå Enter");
            exitCommand = Console.ReadLine();
            if (exitCommand.ToLower().Equals("îòìåíà") || exitCommand.ToLower().Equals(" "))
            {
                Console.WriteLine("Äëÿ çàâåðøåíèÿ ðàáîòû íàæìèòå ëþáóþ êíîïó");
                Console.ReadKey(true);
                break;
            }
        }
    }
    public static void SubscribeMyEvent(object? sender, EventArgs e)
    {
        if (sender is Calc)
            Console.WriteLine(((Calc)sender)._result);
    }
}  



