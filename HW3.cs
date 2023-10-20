using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB
{
    internal class HW3
    {
        static int[,] l { get; set; } = new int[,]
         {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 2, 1, 1, 1 }
            };
        public static int _counter { get; private set; } = 0;

        public static void HasExit(int startI, int startJ)
        {
            if (l[startI, startJ] == 1)
            {
                Console.WriteLine("Начальная точка находится в стене!");
                return;
            }
            else if (l[startI, startJ] == 2)
            {
                _counter++;
                Console.WriteLine("Выход ниходится на входе 0_о!");
                return;
            }

            var stack = new Stack<Tuple<int, int>>();
            stack.Push(new(startI, startJ));

            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                if (l[temp.Item1, temp.Item2] == 2)
                {
                    _counter++;
                    Console.WriteLine("Выход найден!");
                }

                l[temp.Item1, temp.Item2] = 1;

                if (temp.Item2 >= 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 - 1)); // вверх

                if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 + 1)); // низ

                if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 - 1, temp.Item2)); // лево

                if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 + 1, temp.Item2)); // право
            }
            Console.WriteLine($"Всего выходов {_counter}");

        }
    }
}
