using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 600;
            int b = 500;
            int cem = a + b;

            if (cem > 9 && cem < 100 ) 
            {
                Console.WriteLine("cem 2 reqemlidir");
            }
            else if (cem > 99 && cem < 1000 )
            {
                Console.WriteLine("cem 3 reqemlidir");
            }
            else
            {
                Console.WriteLine("nezere alinmayib");
            } 

            

        }
    }
}
