using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetExample
{
    public class primeFactor
    {
        public int a = 10, b = 20;
        public static void factor()
        {
            Utility.stringOUt("Enter the value of  N : ");
            int n = Utility.readInt();
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    if (isPrime(i)==0)
                    {
                        Utility.intOut(i);
                    }
                }
            }
        }
        public  static int isPrime(int i)
        {
            int count = 0;
            for(int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;
                }
            }
            return count;

        }
    }
}
