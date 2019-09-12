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
            for (int i = 1; i <= 100; i++)
            {
                int ansFive;
                int ansThree;
                int ansFiftee;

                ansThree = i % 3;

                if (ansThree == 0)
                {
                    ansFive = i % 5;
                    if (ansFive == 0)
                    {

                        ansFiftee = i % 15;
                        if (ansFiftee == 0)
                        {

                            Console.WriteLine(i + "Fizzbuzz");
                        }
                        else
                        {


                            Console.WriteLine(i);
                        }



                        Console.WriteLine(i + "buzz");
                    }
                    else
                    {


                        Console.WriteLine(i);
                    }


                    Console.WriteLine(i + "Fizz");
                }

               

            }
            Console.ReadLine();
        }
    }
}
