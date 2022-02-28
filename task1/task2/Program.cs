using System;

namespace task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 7;
            int cavab = a % 3;
            int cavab1 = a % 2;

            if (cavab == 0 && cavab1 == 0 )
               
            {
                Console.WriteLine("3-e bolunur cutdur");
            }
            else if ( cavab == 0 && cavab1 != 0   )
            {
                Console.WriteLine("3-e bolunur tekdir");
            }
            else
            {
                Console.WriteLine("3-e bolunmur");
            }


        }
    }
}