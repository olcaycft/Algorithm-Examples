using System;
using System.Collections;
namespace hayyam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Knk Satır sayısı gir= ");
            string satirsayisi = Console.ReadLine();
            int a = Convert.ToInt32(satirsayisi);
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("1");
            for (int i = 0; i < a-1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("1 1");

            ArrayList arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add(1);
            for (int i = 2; i < a; i++)
            {
                ArrayList arr2 = new ArrayList();
                for (int j = 0; j < i+1; j++)
                {
                    if (j==0 )
                    {
                        arr2.Add(1);
                    }
                    else if (j == (i))
                    {
                        arr2.Add(1);
                        break;
                    }
                    else
                    {
                        arr2.Add( Convert.ToInt32(arr1[j-1]) +Convert.ToInt32( arr1[j]));
                    }
                }
                for (int k = 0; k < a-i; k++)
                {
                    Console.Write(" ");
                }
                foreach (var item in arr2)
                {
                    Console.Write(item+" ");
                }
                arr1.Clear();
                arr1 = (ArrayList)arr2.Clone();
                arr2.Clear();
                Console.WriteLine();
            }
        }
    }
}
