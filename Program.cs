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

        Console.WriteLine("����� ���������� � �������� ����������� �� ��������� �������");
        Console.WriteLine();

        while (true)
        {

            calc.ExecuteOperation();


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



