using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //string equation = "10 200";

            ////we will be looking for space using index

            //int index = 0;
            //int spacePosition = -1;
            //while (index < equation.Length)
            //{
            //    if (equation.Substring(index, 1) == "")
            //    {
            //        spacePosition = index;
            //        break;// exits while
            //    }

            //    index++;

            //}

            string equation = "10 200";

            //we will be looking for space using index

            int index = 0;
            int spacePosition = -1;
            while (index < equation.Length)
            {
                if (equation.Substring(index, 1) == "")
                {
                    spacePosition = index;
                    if(index==2)
                    continue;// skips current iteration
                }

                index++;

            }

        }
    }
}
