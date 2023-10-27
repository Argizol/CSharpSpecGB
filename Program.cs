using CSharpSpecGB.Seminar5;
using System;
using System.Collections.Generic;
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

        Console.WriteLine("Добро пожаловать в странный калькулятор по странному заданию");
        Console.WriteLine();

        while (true)
        {        

            calc.ExecuteOperation();

            Console.WriteLine("Продолжить работу?");
            Console.Write("Для завершения работы введите:" +
                " Отмена или поставьте пробел и нажмите Enter\n" +
                "Для продолжения работы нажмите Enter");
            exitCommand = Console.ReadLine();
            if (exitCommand.ToLower().Equals("отмена") || exitCommand.ToLower().Equals(" "))
            {
                Console.WriteLine("Для завершения работы нажмите любую кнопу");
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


