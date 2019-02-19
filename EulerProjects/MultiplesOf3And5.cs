using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    public class MultiplesOf3And5
    {
        public int FindMulbiples(int range)
        {
            int result = 0;
            for (int i = 0; i < range; i++)
            {
                if (i % 3 == 0 || i%5 ==0) result += i;                
            }

            return result;
        }
    }
}
