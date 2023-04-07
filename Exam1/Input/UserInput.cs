using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.Input
{
    class UserInput
    {
        int sumValue = 0;

        public void InputValue()
        {
            Console.WriteLine("InputValue ---------- ");
            while (true)
            {
                Console.Write("수를 입력하세요: ");
                string line = Console.ReadLine();
                Console.WriteLine("line : {0}", line);
                if (line == "end") break;
                sumValue += int.Parse(line);
                Console.WriteLine("sumValue : {0}", sumValue);
            }
            
        }

        public void PrintInputValue()
        {
            Console.WriteLine("PrintInputValue ---------- ");
            Console.WriteLine("End sumValue : {0}", sumValue);
        }
    }
}
