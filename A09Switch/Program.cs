using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A09Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a digit:);

                int digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
                Console.WriteLine("one");
            else if (digit ==2)
                Console.WriteLine("two");
            else if (digit == 3)
                Console.WriteLine("three");
            else if (digit == 4)
                Console.WriteLine("four");
            else
                Console.WriteLine("other");

            switch (digit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                default:
                    Console.WriteLine("other");



            }



        }
       
    }
}
