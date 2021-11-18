using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40, 50, 60, 70, 80, 90,100 };
            Console.Write("Arayacağın rakamı gir= ");
            String a = Console.ReadLine();
            int adim = 0;
            int flag = arr.Length / 2;
            int taban = 0;
            int tavan = arr.Length-1;
            while (adim != (arr.Length/2))
            {
                if (arr[flag]==Convert.ToInt32(a))
                {
                    Console.WriteLine("Aradığın sayı "+(adim+1)+" adımda "+(flag+1)+" elemanda bulundu.");
                    break;
                }
                else if (Convert.ToInt32(a) > arr[flag])
                {
                    taban = flag;
                    flag = flag+((tavan - taban)/2);
                }
                else if (Convert.ToInt32(a) < arr[flag])
                {
                    tavan = flag;
                    flag = ((tavan - taban) / 2);
                }
                adim++;
            }
            if (adim == (arr.Length / 2))
            {
                if (arr[arr.Length-1] == Convert.ToInt32(a))
                {
                    Console.WriteLine("Aradığın sayı " + (adim) + " adımda " + (flag + 1) + " elemanda bulundu.");
                }
            }
        }
    }
}
