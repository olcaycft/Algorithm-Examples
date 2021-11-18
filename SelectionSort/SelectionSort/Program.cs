using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arr = new int[] {54,21,51,62,32,63,1,10};
            int enkucuk=arr[0];
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                int flag = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]<arr[flag])
                    {
                        flag = j; // elimdeki flag sürekli değişecek böylece en küçüüğünü bulacağım
                    }
                }
                int temp = arr[i];
                arr[i]= arr[flag];
                arr[flag] = temp;
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
