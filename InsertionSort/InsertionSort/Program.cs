using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 45, 23, 154, 63, 2, 3, 6 };
            int n = arr.Length;
            for (int i =1; i < n; i++)
            {
                int key = arr[i];
               int j = i - 1;

                while (j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
