﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpSpecGB
//{
//    internal class Seminar3
//    {
//        public bool HasExix(int startI, int startJ)
//        {
//            if (l[startI, startJ] == 1)
//            {
//                Console.WriteLine("Начальная точка находится в стене!");
//                return false;
//            }
//            else if (l[startI, startJ] == 2)
//            {
//                Console.WriteLine("Выход ниходится на входе 0_о!");
//                return true;
//            }

//            var stack = new Stack<Tuple<int, int>>();
//            stack.Push(new(startI, startJ));

//            while (stack.Count > 0)
//            {
//                var temp = stack.Pop();

//                if (l[temp.Item1, temp.Item2] == 2)
//                {
//                    Console.WriteLine("Выход найден!");
//                    return true;
//                }

//                l[temp.Item1, temp.Item2] = 1;

//                if (temp.Item2 >= 0 && l[temp.Item1, temp.Item2 - 1] != 1)
//                    stack.Push(new(temp.Item1, temp.Item2 - 1)); // вверх

//                if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
//                    stack.Push(new(temp.Item1, temp.Item2 + 1)); // низ

//                if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
//                    stack.Push(new(temp.Item1 - 1, temp.Item2)); // лево

//                if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
//                    stack.Push(new(temp.Item1 + 1, temp.Item2)); // право
//            }

//            return false;
//        }
//    }
//}
