using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConcept
{
    public class FizzBuzz
    {
        public static void Logic()
        {

            Console.WriteLine("Enter a Any Number");
            int Num = int.Parse(Console.ReadLine());

            if (Num > 0)
            {
                for (int i = 1; i <= Num; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.Write("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                    Console.Write(" ");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Number...!");
            }
        }
    }
}
