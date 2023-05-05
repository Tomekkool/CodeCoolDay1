using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A06Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            bool isEqual = a == 1;

            a = a + 1;
            a++;// increment by 1

            a += 5; // increment by 5

            a *= 2; // multiply by 2

            a-=5 // decrease by 5
            a/=2

                bool isLess = a < 5;
            bool isGreaterOrEqual = a >= 5;

            bool orCondition = a < 5 || a > 10; // or operator

            bool andCondition = a > 5 && a < 10;
            bool isDifferent = !(a == 5);



      
        }
    }
}
