using System;

namespace Count_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 1, 4, 34, 5, 9, 4, 23, };

           for(int i=arr.Length-1; i>2; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
    }   }
}
