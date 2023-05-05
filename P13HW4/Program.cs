using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("All prime numbers between 1 and 100 are:");

            //looping through whole range of numbers
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                //checking if number divides by smaller ones with no reminder
                for (int j = 2; j<i; j++)
                {
                    if (i%j==0) {
                        isPrime = false;
                        break;
                    }

                }
               if (isPrime)
                {
                    Console.Write(i +" ");
                }     
            }
            Console.ReadKey();
        }
    }
}
