using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouqetsOfRoses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var firstLCM = 0;
            var secondLCM = 0;
            var finalLCM = 0;
            var checkFinalLCM = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (n > m)
            {
                for (int j = 1; j <= m; j++)
                {
                    if ((n * j) % m == 0)
                    {
                        firstLCM = n * j;
                        break;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= n; j++)
                {
                    if ((m * j) % n == 0)
                    {
                        firstLCM = m * j;
                        break;
                    }
                }
            }
            if (k > i)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((k * j) % i == 0)
                    {
                        secondLCM = k * j;
                        break;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= k; j++)
                {
                    if ((i * j) % k == 0)
                    {
                        secondLCM = i * j;
                        break;
                    }
                }
            }
           
            if (firstLCM > secondLCM)
            {
                for (int j = 1; j <= secondLCM; j++)
                {
                    if ((firstLCM * j) % secondLCM == 0)
                    {
                        finalLCM = firstLCM * j;
                        break;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= firstLCM; j++)
                {
                    if ((secondLCM * j) % firstLCM == 0)
                    {
                        finalLCM = secondLCM * j;
                        break;
                    }
                }
            }

            if (finalLCM % 2 == 0)
            {
                if (p % 2 == 1)
                {
                    for (int j = 1; j < p; j++)
                    {
                        if ((finalLCM * j + 1) % p == 0)
                        {
                            checkFinalLCM = finalLCM * j + 1;
                            Console.WriteLine(checkFinalLCM);
                            break;
                        }
                    }
                }
                else if(checkFinalLCM==0)
                {
                    Console.WriteLine("There isn't minimal number of roses");
                }
            }
           else
            {
                for (int j = 1; j < p; j++)
                {
                    if ((finalLCM * j + 1) % p == 0)
                    {
                        checkFinalLCM = finalLCM * j + 1;
                        Console.WriteLine(checkFinalLCM);
                        break;
                    }
                }
                if (checkFinalLCM == 0)
                {
                    Console.WriteLine("There isn't minimal number of roses");
                }
            }
        }
    }
}
