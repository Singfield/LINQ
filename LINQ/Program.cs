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
            {
                return IsPrime(-nb);
            }
            else if (nb == 1)
                return false;
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
           List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

          
           List<int> annees = new List<int> { 1997, 1998, 1900,2002, 2003, 2005,2008};

            
            var anneQuery =
                from annee in annees
                where DateTime.IsLeapYear(annee)
                select annee;

            int nbrequetes = anneQuery.Count();

            if( nbrequetes==0)
            {
                Console.WriteLine(":/");
                int temp=annees.Max();
                
                for(int i=0; i<=3; i++)
                {
                    var nextyear = temp + i;
                    if (DateTime.IsLeapYear(nextyear))
                    {
                        Console.WriteLine("la prochaine annee est : " + nextyear);
                    }
                }
            }

            foreach (int annee in anneQuery)
            {
                Console.Write("{0,1} ",annee);
            }
        
            var numQuery =
            from num in numbers
            where ( IsPrime(num)) ==true
            select num;

            // 3. Query execution.
            foreach (int num in numQuery.ToList())
            {
                Console.Write("{0,1} ", num);
            }
        
        }
    }
}
