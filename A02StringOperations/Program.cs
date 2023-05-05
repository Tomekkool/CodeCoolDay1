using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            int stringLength = sentence.Length;

            string s1 = sentence.Substring(4);
            Console.WriteLine(s1);

            string s2 = sentence.Substring(4, 5);
            Console.WriteLine(s2);

            bol containsword = sentence.Contains("jumps");
            Console.Writeline(containsword);
        

            Console.WriteLine(stringLength);

            bool b1 = true;
            bool b2 = false;

            string lowerCase = sentence.ToLower();
            string upperCase = sentence.ToUpper();

            string s3 = "the" + "quick";

            string s4 = sentence + "again";

            string s5 = "quick".ToUpper();

            int position = sentence.IndexOf



            Console.ReadKey();
        }

    }
}
