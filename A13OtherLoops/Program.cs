using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13OtherLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Example sentence of fox and the dog";

            int index = 0;

            //while (index , sentence.Length)
            //{
            //    Console.WriteLine(sentence.Substring(index, 1));
            //    index++;

            //}

            do
            {

                Console.WriteLine(sentence.Substring(index, 1));
                index++;

            } while (index < sentence.Length);

            //do-while invokes more than one iteration

            for (int i = 0; i < sentence.Length; i++) // index is already increased, so you dont have to remember it
            {
                Console.WriteLine(sentence.Substring(index, 1));
            }

            //foreach - is another type of loop

        }
    }
}
