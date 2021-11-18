using System;
using System.Collections;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            int[] arrs = new int[10] {10, 20, 80, 30, 60, 50,
                     110, 100, 130, 170};


            string a =Console.ReadLine();
            int flag = 0;

            for (int i = 0; i < arrs.Length; i++)
            {
                if (arrs[i]==Convert.ToInt32(a))
                {
                    Console.WriteLine(a+ " sayısı "+(i+1) +". de bulundu...");
                    flag = 1;
                    break;
                }
            }
        }
    }
}
