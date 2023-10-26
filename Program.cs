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

        Console.WriteLine("����� ���������� � �������� ����������� �� ��������� �������");

        while (true)
        {
           
            Console.WriteLine();

            num = calc.EnterNum();
            calc.SwitchAndExecuteOperation(num);

            Console.WriteLine("���������� ������?");
            Console.WriteLine("��� ���������� ������ �������:" +
                " ������ ��� ��������� ������ � ������� Enter" +
                "��� ����������� ������ ������� Enter");
            exitCommand = Console.ReadLine();
            if (exitCommand.ToLower().Equals("������") || exitCommand.ToLower().Equals(" "))
            {
                Console.WriteLine("��� ���������� ������ ������� ����� �����");
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


