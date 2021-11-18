using System;

namespace swapintswithtwovariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            a = a * b;   //15
            b = a / b;   //5 
            a = a / b;   //3


            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
