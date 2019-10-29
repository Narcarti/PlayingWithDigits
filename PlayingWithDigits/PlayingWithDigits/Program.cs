using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digPow(89, 1));
            Console.WriteLine(digPow(695, 2));
            Console.WriteLine(digPow(46288, 3));

            Console.ReadKey();
        }


        public static long digPow(int n, int p)
        {
            string nums = n.ToString();
            char[] numA = nums.ToCharArray();
            int powCnt = p;
            double dig = 0;
            for (int idx = 0; idx < numA.Length; idx++)
            {
                dig += Math.Pow(int.Parse(numA[idx].ToString()), p+idx);
                powCnt++;
            }
            Console.WriteLine(dig);
            Console.WriteLine(dig /n);
            Console.WriteLine();

            if (dig % n == 0)
            {
                return (long)dig / n;
            }
            return ((dig == n || (dig == n * p)) ? p : -1 );
        }
    }
}
