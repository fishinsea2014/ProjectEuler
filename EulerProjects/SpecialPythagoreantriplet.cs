using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EulerProjects
{
    public class SpecialPythagoreantriplet
    {
        /// <summary>
        /// A Pythagorean triplet is a set of three natural numbers, a < b < c 
        /// a2 + b2 = c2
        /// For example, 32 + 42 = 9 + 16 = 25 = 52.
        /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        /// Find the product abc.
        /// </summary>
        /// <param name="sumOfSide"></param>
        /// <returns></returns>
        public Tuple<int, int, int > GetSideLength(int sumOfSide)
        {
            foreach (int a in Enumerable.Range(0, sumOfSide+1))
            {
                foreach ( int b in Enumerable.Range(a + 1, sumOfSide+1))
                {
                    int c = 1000 - a - b;
                    if (b<c && (Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                    {
                        return new Tuple<int,int,int>(a, b, c);
                    }
                }
            }

            return new Tuple<int, int, int>(0, 0, 0);
        }

       
    }
}
