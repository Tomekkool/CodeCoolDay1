using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter two integer vaues separated by space");
            string numbers = Console.ReadLine();


            int digitCount = Convert.ToInt32(numbers.Length);
            int spacePosition = numbers.IndexOf(" ");

            int value1 = Convert.ToInt32(numbers.Substring(0, spacePosition));
            int value2 = Convert.ToInt32(numbers.Substring(spacePosition, digitCount-spacePosition));

            Console.WriteLine($"{value1} {value2}");
            if (value1 > value2)
                Console.WriteLine($"{value1} is greater than {value2}");
            else if (value1 < value2) Console.WriteLine($"{value2} is greater than {value1}");
            else Console.WriteLine("Both values are equal");

            Console.ReadKey();
        }
    }
}
