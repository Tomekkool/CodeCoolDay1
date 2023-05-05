using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 0;
            string s = "dog";


            try
            {
                double c = a / b;
                string s1 = s.Substring(3, 1);

            }
            catch (DivideByZeroException ex)//you can have general or specific exception here
            {
                Console.Write("do not divide by zero");
                File.AppendAllText("c:\\Projekty\\data\\errors\\errorlog.txt", Environment.NewLine + ex.Message);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Wrong index");
          
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong something");
            }

            Console.ReadKey();
        }
    }
}
