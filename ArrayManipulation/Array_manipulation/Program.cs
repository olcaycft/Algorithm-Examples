using System;
using System.Collections.Generic;

namespace Array_manipulation
{
    class Program
    {

        public static string FindIntersection(string[] strArr)
        {
            string result = "";
            // code goes here  
            string[] strArr1 = strArr[0].Split(',');
            string[] strArr2 = strArr[1].Split(',');
            foreach (var item in strArr1)
            {
                foreach (var item2 in strArr2)
                {
                    if (item.Trim()==item2.Trim())
                    {
                        result += item.Trim() + ',';
                    }
                }
            }
            if (result.EndsWith(','))
            {
                result=result.Substring(0,result.Length-1);
            }
            if(string.IsNullOrEmpty(result))
            {
                result = "false";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));
        }
    }
}
