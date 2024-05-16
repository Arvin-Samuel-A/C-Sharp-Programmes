using System;

namespace tribonacci
{
    internal class Tribonacci
    {

        static void Main(string[] args)
        {

            long Terms, Num1, Num2, Num3;

            Console.WriteLine("We are going to print the Tribonacci Series!!!\n");

            Console.Write("Enter the Number of Terms : ");
            Terms = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter the Third Number : ");
            Num3 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            Trib(Terms, Num1, Num2, Num3);

        }

        static void Trib(long Terms, long Num1, long Num2, long Num3)
        {

            long Var1, Var2;

            for (int i = 0; i < Terms; i++)
            {

                Console.WriteLine(Num1);
                Var1 = Num1;
                Var2 = Num2;
                Num1 = Num2;
                Num2 = Num3;
                Num3 += Var1 + Var2;

            }

            Console.WriteLine();

        }

    }
}