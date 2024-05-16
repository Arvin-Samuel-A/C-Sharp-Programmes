using System;

namespace fibonacci
{
    internal class Fibonacci
    {

        static void Main(string[] args)
        {

            long Terms, Num1, Num2;

            Console.WriteLine("We are going to print the Fibonacci Series!!!\n");

            Console.Write("Enter the Number of Terms : ");
            Terms = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(); 

            Fib(Terms, Num1, Num2);

        }

        static void Fib(long Terms, long Num1, long Num2)
        {

            long Var;

            for (int i = 0; i < Terms; i++)
            {

                Console.WriteLine(Num1);
                Var = Num1;
                Num1 = Num2;
                Num2 += Var;

            }

            Console.WriteLine();

        }

    }
}
