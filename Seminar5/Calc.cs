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
            {"Галя, отмена!", "Отмена последней операции" },
            };

        public void Divide(double x)
        {
            _result /= x;
            PrintResult();
            _stack.Push(_result);
        }

        public void Mult(double x)
        {
            _result *= x;
            PrintResult();
            _stack.Push(_result);
        }

        public void Sub(double x)
        {
            _result -= x;
            if(_result < 0) throw new ArithmeticException("Сумма не должна быть меньше 0");
            PrintResult();
            _stack.Push(_result);
        }

        public void Sum(double x)
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

        public double EnterNum()
        {
            Console.WriteLine("Введите число: ");
            var sNum = Console.ReadLine();
            if (MyDoubleTryParse(sNum, out double num))
            {
                if (num < 0) throw new ArgumentException("Число не может быть меньше 0");
            }
            Console.Clear();
            return num;
        }

        public void ExecuteOperation()
        {
            PrintOperations();
            Console.WriteLine("Введите знак математической операции:  ");
            string operation = Console.ReadLine()!;

            if (Dict.ContainsKey(operation))
            {
                double num = 0;
                switch (operation)
                {
                    case "+":
                        try
                        {
                            num = EnterNum();
                        }
                        catch(ArgumentException e)
                        {
                            Console.WriteLine(e); 
                        }
                        
                        try
                        {
                            Sum(num);
                        }
                        catch (ArithmeticException ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case "-":
                        try
                        {
                            num = EnterNum();
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e);
                        }
                        Sub(num); ;
                        break;
                    case "/":
                        try
                        {
                            num = EnterNum();
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e);
                        }
                        Divide(num); ;
                        break;
                    case "*":
                        try
                        {
                            num = EnterNum();
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e);
                        }
                        Mult(num); ;
                        break;
                    case "Галя, отмена!":
                        CancelLast();
                        break;
                }
            }
        }

        public static bool MyDoubleTryParse(string str, out double num)
        {
            try
            {
                num = double.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                num = 0;
                return false;
            }
            return true;
        }
    }
}

