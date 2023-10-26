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
            handler?.Invoke(this,new EventArgs());
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
                Console.WriteLine("Невозможно отменить послдеднее действие!");
            }
        }

    }
}
