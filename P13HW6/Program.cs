using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13HW6
{//fibonacci calc
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number limiting the Fibonacci sequence you want to generate:");
 
            int n = Convert.ToInt32(Console.ReadLine());

       
            // the first two numbers in the sequence
            int num1 = 0;
            int num2 = 1;

            // Print the first number in the sequence
            Console.Write(num1 + " ");

            // Loop through the sequence and print each number
            while (num2 <= n)
            {
                Console.Write(num2 +" ");
                int nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
            }

            Console.ReadLine();
        }
    }     
    
}
