using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HW - 1 start
            Console.WriteLine("Enter the positive integer value:");
            int n = Convert.ToInt32(Console.ReadLine());
                        int i = 2;
                int sum=0;

            while (i <= n) { 
            
                sum=sum+i;
            
            i=i+2;
            }
            Console.WriteLine($"The sum of all even numbers beteween 1 and {n} equals {sum}");

            //HW - 1 end

            Console.ReadKey();
        }
    }
}
