using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++ )
            {
                Console.WriteLine(FizzBuzz(i));
            }

            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) 
            {
                // if divisible by 5 and 3 print "FizzBuzz"
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                // if divisible by only 3 print "Fizz"
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                // if divisible by only 5 print "Buzz"
                return "Buzz";
            }
            else
                // else print the number as a string
                return number.ToString();
        }
    }
}
