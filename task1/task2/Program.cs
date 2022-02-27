using System;

namespace task2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 6;
            int cavab = a % 3;

            if (a % 3 == 0)
            {
                Console.WriteLine("3-e bolunur cutdur");
            }
            else if (a % 3 == 0)
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