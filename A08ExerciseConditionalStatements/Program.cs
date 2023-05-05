using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A08ExerciseConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an equation consisiting of two single digit numbers and ");

                string equation = Console.ReadLine();
            //4+5

            equation.Substring(1, 1);
            string operation = equation.Substring(1, 1);
            int num1 = Convert.ToInt32(equation.Substring(0, 1));
            int num2 = Convert.ToInt32(equation.Substring(2));

            double? result = null; //the "?" means that variable may by nulled

            if (operation =="+")
                result = num1 + num2;
            else if (operation=="-")
                result = num1 - num2;
            else if (operation == "*")
                result = num1 * num2;
            else if (operation == "/")
                result = Convert.ToDouble(num1)/num2;

           // Console.WriteLine(result);

         

            if (result != null)
                Console.WriteLine(result);
            else
                Console.WriteLine("cannot calculate value");

            Console.ReadKey();

            // int height = Convert.ToInt32(Console.ReadLine());

        }
    }
}
