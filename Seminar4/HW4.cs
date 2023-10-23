using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSpecGB.Seminar4
{
    internal static class HW4
    {
        public static bool FindSumParts(int[] numsArr, int findNum)
        {        
            for (int i = 1; i < numsArr.Length - 1; i++)
            {
                int left = i - 1;
                int right = i + 1;
                int result;

                result = numsArr[left] + numsArr[i] + numsArr[right];
                if (result == findNum)
                {
                    Console.WriteLine($"Искомое число {findNum} состоит из {numsArr[left]} + {numsArr[i]} + {numsArr[right]}");
                    return true;
                }
                else
                {
                    left++;
                    right++;
                }                
            }
            Console.WriteLine("Подходящих чисел не найдено");
            return false;
        }
    }
}
