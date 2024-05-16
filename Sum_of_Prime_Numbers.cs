using System;
using System.Threading;

namespace sum_of_prime_numbers
{

    class Sum_of_Prime_Numbers
    {

        static public long Sum = 2L;

        public static void Main(string[] args)
        {

            long Terms;

            Console.WriteLine("We are going to Calculate the Sum of Prime Numbers till the user-entered limit!!!\n");

            Console.Write("Enter the Limit : ");
            Terms = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            Primes(Terms);

            Console.WriteLine($"The Sum of Prime Numbers till {Terms} is : {Sum}");
            Console.WriteLine();

        }

        private static void Primes(long Terms)
        {

            double Var = Terms - 2;

            Var = Var / 12;

            Thread[] Threads = new Thread[12];

            for (int x = 0; x < 12; x++)
            {

                Threading Obj = new Threading((long)((Var * x) + 3), (long)((Var * (x + 1)) + 3));
                
                Threads[x] = new Thread(Obj.Primes);


            }

            foreach (Thread th in Threads)
            {

                th.Start();
                th.Join();

            }

        }

    }

    class Threading
    {

        private static Mutex Atomic = new Mutex();
        private long Num1, Num2;
        private long Total = 0;

        public Threading(long Number1, long Number2)
        {

            Num1 = Number1;
            Num2 = Number2;

        }

        public void Primes()
        {

            for (long x = Num1;  x < Num2; x++)
            {

                if (x % 2 != 0)
                {

                    bool Found = true;

                    long Var = (long) (Math.Sqrt((double)x) + 1);

                    for (long y = 3; y < Var; y += 2)
                    {

                        if (x % y == 0)
                        {

                            Found = false;
                            break;

                        }

                    }

                    if (Found)
                    {

                        Total = Total + x;

                    }

                }

            }

            Atomic.WaitOne();
            Source.Sum = Source.Sum + Total;
            Atomic.ReleaseMutex();

        }

    }

}
