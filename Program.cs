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
        int num = 0;

        Console.WriteLine("Добро пожаловать в странный калькулятор по странному заданию");

        while (true)
        {
           
            Console.WriteLine();

            num = calc.EnterNum();
            calc.SwitchAndExecuteOperation(num);

            Console.WriteLine("Продолжить работу?");
            Console.WriteLine("Для завершения работы введите:" +
                " Отмена или поставьте пробел и нажмите Enter" +
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


