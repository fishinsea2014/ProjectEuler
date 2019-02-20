using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Euler project solutions by Jason==");
            #region Q1: Multiples of 3 and 5
            {
                Console.WriteLine("Question 1: Multiples of 3 and 5 ");
                MultiplesOf3And5 multiplesOf3And5 = new MultiplesOf3And5();
                Console.WriteLine("--Solution: " + multiplesOf3And5.FindMulbiples(1000));
            }
            #endregion
            #region Q2: Even Fibonacci numbers
            {
                Console.WriteLine("Question 2: Even Fibonacci numbers");
                EvenFibonacciNumbers evenFibonacciNumbers = new EvenFibonacciNumbers();
                Console.WriteLine("--Solution: " + evenFibonacciNumbers.SumOfEvenTers(4000000));
            }
            #endregion

            #region Q9: Special Pythagorean triplet
            {
                Console.WriteLine("Question 9: Special Pythagorean triplet");
                SpecialPythagoreantriplet specialPythagoreantriplet = new SpecialPythagoreantriplet();
                int product = specialPythagoreantriplet.GetSideLength(1000).Item1
                              * specialPythagoreantriplet.GetSideLength(1000).Item2
                              * specialPythagoreantriplet.GetSideLength(1000).Item3;
                Console.WriteLine($"--Solution: The product of abc is {product}");
            } 
            #endregion


            Console.ReadKey();
        }
    }
}
