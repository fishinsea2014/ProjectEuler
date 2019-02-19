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
            {
                Console.WriteLine("Question 1: ");
                MultiplesOf3And5 multiplesOf3And5 = new MultiplesOf3And5();
                Console.WriteLine("--Solution: " + multiplesOf3And5.FindMulbiples(1000));
            }
            Console.ReadKey();
        }
    }
}
