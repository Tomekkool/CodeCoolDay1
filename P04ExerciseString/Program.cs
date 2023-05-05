using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ExerciseString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Part 1");
            Console.WriteLine("enter 2 nums");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            string sumAsString = Convert.ToString(sum);

            int digitCount = Convert.ToInt32(sumAsString.Length);

            string report1 = "The result" + sum + " consists of:" + digitCount + "digits";

            string report2 = $"the result {sum} onsists of: {digitCount} digits";

            string report3 = string.Format("the result {0} onsists of: {1} digits",sum,digitCount);


            Console.WriteLine(report3);

            Console.WriteLine("Part 2");

            Console.WriteLine("enter 2 nums seperated by space");

            string numbers = Console.ReadLine(); //200 10

            int spacePosition = numbers.IndexOf(" ");

            int newNumber1 = Convert.ToInt32(numbers.Substring(0, spacePosition));
            int newNumber2 = Convert.ToInt32(numbers.Substring(0, spacePosition +1));

            int newSum = newNumber1 + newNumber2;

            Console.WriteLine(newSum);

            Console.ReadKey();

        }
    }
}
