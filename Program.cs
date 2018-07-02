using System;
using System.Threading;

//Made by AleX4270(2018)
//Feel free to use :)

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program will write as much Fibonacci numbers as you want :)");

            
            ulong[] fib = new ulong[500]; //This array contains our Fibonacci numbers.
            fib[1] = 1; //First fibonacci number is 0 so second has to be 1 :)

            int howMuch; //This variable is used to contain information about how much numbers program should print.

            input:
            Console.WriteLine("How much Fibonacci numbers do you want to see?: ");
            try //Simple try and catch :) In case someone will type something else instead of a number.
            {
                howMuch = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   Error! Try again!");
                Console.ForegroundColor = ConsoleColor.White;

                goto input;
            }

            if(howMuch > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep in mind that your computer may not be able to write out such large numbers!"); //Simple warning message
                Console.ForegroundColor = ConsoleColor.White;                                             
                Thread.Sleep(5000); 


            }

            Console.WriteLine("The value of the {0} Fibonacci number is: {1}", 1, fib[1]);
            try //Another try and catch in case someone will type numbers above 10000.
            {
                for (int i = 2; i <= howMuch; i++) //For loop that prints every fibonacci number on the screen.
                {
                    fib[i] = fib[i - 2] + fib[i - 1];
                    Console.WriteLine("The value of the {0} Fibonacci number is: {1}", i, fib[i]);
                }

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Too many numbers!");
                Console.ForegroundColor = ConsoleColor.White;

            }

            Console.Read();
        }
    }
}
