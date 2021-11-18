using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı gir= ");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int c;
            if (b > 10) 
            { 
                c = ((b / 2)); 
            }
            else
            {
                c = b;
            }
            
            int sonuc = Isprime(c,b);
            if (sonuc==0)
            {
                Console.WriteLine("Sayı asal değil");
            }
            else if (sonuc==1)
            {
                Console.WriteLine("Sayınız ASAL");
            }
        }
        static int Isprime (int h, int c) {
            if (c == 1)
            {
                return 1;
            }
            else if (c == 2)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i < h; i++)
                {
                    if (c % i == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                return 1;
            }
        }
    }
}
