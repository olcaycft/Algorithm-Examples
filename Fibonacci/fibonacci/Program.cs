using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Aşama giriniz = ");
             string asama= Console.ReadLine();
             int asama2 = Convert.ToInt32(asama);
             int f = 0;
             int s = 1;
             int n3;
             for (int i = 2; i < asama2; i++)
             {
                 n3 = f + s;
                 Console.Write(n3+" ");
                 f = s;
                 s = n3;

             }*/

            Console.Write("Aşama giriniz = ");
            string asama = Console.ReadLine();
            int asama2 = Convert.ToInt32(asama);

            Fibonna(1,0,1, asama2);
        }

        static int Fibonna(int i, int f, int s,int asama) {
            int n3;
            if (i == asama)
            {
                return 0;
            }
            n3 = f + s;
            Console.Write(n3+" ");
            f = s;
            s = n3;
            i++;
            return Fibonna(i,f, s,asama);
        }
    }
}
