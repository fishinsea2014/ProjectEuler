using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    public class EvenFibonacciNumbers
    {
        public int SumOfEvenTers(int range)
        {
            int a = 1, b = 2, result=2;

            while (b <= range)
            {
                a = a + b;
                int tmp = a;
                a = b;
                b = tmp;
                if (b % 2 == 0) result += b;
            }
            return result;
        }
    }
}
