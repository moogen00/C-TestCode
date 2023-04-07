using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Utils
{
    class Calc
    {
        
        public static int Add(int a, int b)
        {
            Console.WriteLine("두 int형 끼리의 덧셈");
            return a + b;
        }

        public static double Add(double a, double b)
        {
            Console.WriteLine("두 double형 끼리의 덧셈");
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            Console.WriteLine("세 int형 끼리의 덧셈");
            return a + b + c;
        }
    }
}
