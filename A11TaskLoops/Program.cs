using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11TaskLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write a sentence");
            string sentence1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Please enter any character or word");
            string charOrWord1 = Console.ReadLine().ToUpper();

            int index = 0;
            int count = 0;

            while (index <= sentence1.Length - charOrWord1.Length)
            {
                string substring = sentence1.Substring(index, charOrWord1.Length);

                if (substring == charOrWord1)
                    count++;
                index++;

                      }

            string pattern = "The word / character '{0}' occurs in the given sentence '{1}' times.";

            Console.WriteLine(string.Format(pattern,charOrWord1,count));
            Console.ReadKey();

        }
    }
}
