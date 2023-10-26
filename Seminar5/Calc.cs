using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.Seminar5
{
    internal class Calc : ICalc
    {
        public double _result { get; set; } = 55;

        public event EventHandler<EventArgs> handler;
        public Stack<double> _stack { get; set; } = new Stack<double>();
        public Dictionary<string, string> Dict { get; set; } = new Dictionary<string, string>()
            {
            {"+", "Сложение" },
            {"-", "Вычитание" },
            {"*", "Умножение" },
            {"/", "Деление" },
            {"Отменить последнюю", "Отмена последней операции" },
            };

        public void Divide(int x)
        {
            _result /= x;
            PrintResult();
            _stack.Push(_result);
        }

        public void Mult(int x)
        {
            _result *= x;
            PrintResult();
            _stack.Push(_result);
        }

        public void Sub(int x)
        {
            _result -= x;
            PrintResult();
            _stack.Push(_result);
        }

        public void Sum(int x)
        {
            _result += x;
            PrintResult();
            _stack.Push(_result);
        }

        public void PrintResult()
        {
            handler?.Invoke(this, new EventArgs());
        }
        public void CancelLast()
        {
            if (_stack.TryPop(out double res))
            {
                _result = res;
                Console.WriteLine("Последнее действие отменено. Результат равен:");
                PrintResult();
            }
            else
            {
                Console.WriteLine("Невозможно отменить последнее действие!");
            }
        }

        public void PrintOperations()
        {
            Console.WriteLine("Доступные операции: ");
            foreach (var item in Dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
                Console.WriteLine();
            }
        }

        public int EnterNum()
        {
            Console.WriteLine("Введите число: ");
            var sNum = Console.ReadLine();
            if (int.TryParse(sNum, out int num)) { }
            Console.Clear();
            return num;
        }

        public void SwitchAndExecuteOperation(int num)
        {
            PrintOperations();
            Console.WriteLine("Введите знак математической операции:  ");
            string operation = Console.ReadLine()!;

            if (Dict.ContainsKey(operation))
            {
                switch (operation)
                {
                    case "+":
                        Sum(num);
                        break;
                    case "-":
                        Sub(num); ;
                        break;
                    case "/":
                        Divide(num); ;
                        break;
                    case "*":
                        Mult(num); ;
                        break;
                    case "Отменить последнюю":
                        CancelLast();
                        break;
                }
            }
        }
    }
}

