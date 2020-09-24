using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public static bool IsPrime(int nb)
        {
            if (nb < 0)
                return IsPrime(-nb);
            else if (nb <= 3)
                return true;
            else
            {
                int sqrt_int = (int)Math.Sqrt(nb);
                for (int i = 2; i <= sqrt_int; i++)
                {
                    if (nb % i == 0)
                        return false;
                }

                return true;
            }
        }
        static void Main(string[] args)
        {
           List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            
            

            var numQuery =
            from num in numbers
            where ( IsPrime(num)) ==true
            select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
