using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height")

                int height = Convert.ToInt32(Console.ReadLine());
            bool condition1 = height > 180;
            if (condition1)
            {
                Console.WriteLine("tall");
            }
            else
            {
                Console.WriteLine("short");
            }

            if (height < 160)
                Console.WriteLine("short");
            else if (height > 180)
                Console.WriteLine("tall");
            else
                Console.WriteLine("average");

            string report;
            if (height < 150)
                report = "very short";
            else if (height < 160)
                report = "short";
            else if (height < 170)
                report = "average";
            else if (height < 180)
                report = "tall";

            //ternary operator

            string result;

            if (height > 180)
                result = "tall";
            else result = "short";
            string result1 = height > 180 ? "tall" : "short";

            string result2 = height 180 ? "very tall" : height < 160 ? "short" : "average";




        }
    }
}
