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
            
            var firstNOK = 0;
            var secondNOK = 0;
            var finalNOK = 0;
            var checkFinalNOK = 0;
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
                        firstNOK = n * j;
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
                        firstNOK = m * j;
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
                        secondNOK = k * j;
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
                        secondNOK = i * j;
                        break;
                    }
                }
            }
           
            if (firstNOK > secondNOK)
            {
                for (int j = 1; j <= secondNOK; j++)
                {
                    if ((firstNOK * j) % secondNOK == 0)
                    {
                        finalNOK = firstNOK * j;
                        break;
                    }
                }
            }
            else
            {
                for (int j = 1; j <= firstNOK; j++)
                {
                    if ((secondNOK * j) % firstNOK == 0)
                    {
                        finalNOK = secondNOK * j;
                        break;
                    }
                }
            }

            if (finalNOK % 2 == 0)
            {
                if (p % 2 == 1)
                {
                    for (int j = 1; j < p; j++)
                    {
                        if ((finalNOK * j + 1) % p == 0)
                        {
                            checkFinalNOK = finalNOK * j + 1;
                            Console.WriteLine(checkFinalNOK);
                            break;
                        }
                    }
                }
                else if(checkFinalNOK==0)
                {
                    Console.WriteLine("There isn't minimal number of roses");
                }
            }
           else
            {
                for (int j = 1; j < p; j++)
                {
                    if ((finalNOK * j + 1) % p == 0)
                    {
                        checkFinalNOK = finalNOK * j + 1;
                        Console.WriteLine(checkFinalNOK);
                        break;
                    }
                }
                if (checkFinalNOK == 0)
                {
                    Console.WriteLine("There isn't minimal number of roses");
                }
            }
        }
    }
}
