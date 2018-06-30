﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This program will write as much Fibonacci numbers as you want :)");

            
            ulong[] fib = new ulong[10000];
            fib[1] = 1;

            int howMuch;

            input:
            Console.WriteLine("How much Fibonacci numbers do you want to see?: ");
            try
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
                Console.WriteLine("Keep in mind that your computer may not be able to write out such large numbers!");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(5000);


            }

            Console.WriteLine("The value of the {0} Fibonacci number is: {1}", 1, fib[1]);
            try
            {
                for (int i = 2; i <= howMuch; i++)
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
