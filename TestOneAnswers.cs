using System;

namespace TestOneCode
{
    class DriverBot
    {
        static void Main(string[] args)
        {
            One_B();
        }

        static void One_B()
        {
            int count = 1;

            while (count < 4)
            {
                Console.WriteLine("count is {0}", count);
            }
            Console.ReadLine();
        }

        static void One_C()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine("The sum is {0}", sum);
            Console.ReadLine();

        }
        static void One_D()
        {
            int i = -3;
            while (i < 4)
            {
                Console.WriteLine("{0}", i);
                i--;
            }

        }

        static void One_E()
        {
            Console.WriteLine("in method One_E");
            int i = -3;
            for (; i > 100; i = i - 5)
            {
                Console.WriteLine("{0", i);
                i--;
            }
            Console.ReadLine();
        }

        static void Section_2()
        {
            int count = 1;
            int iteration = 0;

            while (count < 10)
            {
                iteration += 1;
                Console.WriteLine("iteration is {0}", iteration);

                count += 1;

                if (count > 5)
                {
                    Console.WriteLine("I am in the IF Statement now");
                    count += 2;
                }
                Console.WriteLine("Point B: count is {0}", count);
            }

            Console.WriteLine("the final value of count is {0}", count);
            Console.ReadLine();
        }

        static void Section_3_A()
        {
            int sum = 0;

            for (int i = 1; i < 11; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum is {0}", sum);
            Console.ReadLine();
        }

        static void Section_3_B()
        {
            Console.WriteLine("Section 3 B: ");
            int sum = 0;
            int counter = 0;

            while (counter < 11)
            {
                sum += counter++;

            }
            Console.WriteLine("sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
