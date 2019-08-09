using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjects
{
    public static class CoinPartitions
    {
        /// <summary>
        /// Let p(n) represent the number of different ways in which n coins can be separated into piles. For example, 
        /// five coins can be separated into piles in exactly seven different ways, so p(5)=7.
        /// OOOOO
        /// OOOO   O
        /// OOO   OO
        /// OOO   O O
        /// OO OO   O
        /// OO   O O   O
        /// O   O O   O O
        //Find the least value of n for which p(n) is divisible by one million.
        
        /// </summary>
        static int range = 1000000;
        static int[] coins = new int[range];
        
        public static int  GetPartitions()
        {
            coins[0] = 1;
            coins[1] = 1;
            int n = 1;
            do
            {
                n++;
                coins[n] = PartateCoins(n);
            } while (coins[n] != 0);

            return n;
        }

        private static int PartateCoins(int n)
        {
            int res = 0, k = 1, a = 2, b = 1, s = 1;
            while (n >= a)
            {
                res += s * (coins[n - a] + coins[n - b]);
                a += 3 * k + 2;
                b += 3 * k + 1;
                s *= -1;
                k += 1;
            }
            res += (n >= b) ? s * coins[n - b] : 0;
            return res % range;
        }
    }
}
