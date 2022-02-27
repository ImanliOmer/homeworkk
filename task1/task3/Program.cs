using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int cem = a + b;

            if (a + b >= 100) 
            {
                Console.WriteLine("cem 3 reqemlidir");
            }
            else if (a + b <= 100)
            {
                Console.WriteLine("cem 2 reqemlidir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            } 

            

        }
    }
}
