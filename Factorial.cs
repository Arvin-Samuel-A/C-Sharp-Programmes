using System;

namespace factorial
{

    class Factorial
    {

        static void Main(string[] args)
        {

            long Number;

            Console.WriteLine("We are going to Calculate the Factorial of the user-entered Number!!!\n");

            Console.Write("Enter the Number to Calculate it's Factorial : ");
            Number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"The Factorial of {Number} is : {Fac(Number)}");
            Console.WriteLine();

        }

        static long Fac(long Num)
        {

            if (Num > 1) return Num * Fac(Num - 1);

            else return Num;
          
        }

    }

}