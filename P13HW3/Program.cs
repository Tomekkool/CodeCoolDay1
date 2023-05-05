using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P13HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int ordinal = 1;
            int sum = 0;
            int iValue=0;
            double avg = 0;
            string ordinaltxt = "1st";

            for (int i = 0; i < n; i++)
            {
                ordinal = i +1;
                if (ordinal == 2)
                    ordinaltxt = "2nd";
                else if (ordinal == 3)
                    ordinaltxt = "3rd";
                else if (ordinal > 3)
                    ordinaltxt = $"{ordinal}th";
                else
                { }
                    
                Console.WriteLine($"Enter the {ordinaltxt} of {n} values");
                iValue = Convert.ToInt32(Console.ReadLine());
                sum = sum + iValue;
            }
            avg= sum / n;
            Console.WriteLine($"The mean average of given {n} numbers is {avg}");
            Console.ReadKey();  
           

      
        }
    }
}
