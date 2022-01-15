using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int input;
            for(int i = 1; i <= n; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                for(int j=2;j<=input/j;j++)
                {
                    if(input%j==0)
                    {
                        input=1;
                    }
                }
                if(input==1)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");    
                }
            }
        }
    }
}
