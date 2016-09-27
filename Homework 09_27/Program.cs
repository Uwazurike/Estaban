using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09_27
{
    class Program
    {
        private static int uservalue;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

            }


            Console.WriteLine("hello welcome to brainiac,the expert on 3's and 5's.  let's get started.");
            Console.WriteLine("ok go ahead and pick a number between 1 and 100");
            Console.WriteLine("brainiac will yell fizz for a number divisible by 3 and buzz for a number divisible by 5");
            Console.WriteLine("you also get a fizz buzz for a number divisible by both");


            Console.Write("go ahead give it a try");

            string UserValue = Console.ReadLine();

            int newNum = Convert.ToInt32(UserValue);

            if (newNum % 3 == 0 && newNum % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (newNum % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (newNum % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("oops you are out of bounds!");
            }

                Console.ReadLine();
        }
    }
}