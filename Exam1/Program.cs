using System;
using Exam1.Utils;
using Exam1.Input;
using Exam1.ClassTest;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요: ");
                string line = Console.ReadLine();
                Console.WriteLine("== input value : {0} ==", line);
                if (line == "end") break;
                
                
                switch(int.Parse(line))
                {
                    case 1:
                        {
                            Console.WriteLine("{0}", Calc.Add(50, 10));
                            Console.WriteLine("{0}", Calc.Add(544.2, 63.2));
                            Console.WriteLine("{0}", Calc.Add(4, 7, 9));
                        }
                        break;

                    case 2:
                        {
                            UserInput i = new();
                            i.InputValue();
                            i.PrintInputValue();
                        }
                        break;

                    case 3:
                        {
                            ListTest t1 = new();
                            t1.RankAndLengthTest();
                            t1.ClearTest();
                            t1.ResizeTest();
                            t1.ReturnValueOfIndexTest();
                            t1.ShowValue2nd();
                        }
                        break;
                    case 4: 
                         {
                            Dog dog = new Dog();
                            dog.SetDog("칸", "남", "철수");
                            //dog.name = "칸";
                            //dog.gender = "남";
                            //dog.ownernames = "철수";

                            dog.Bark();

                            Console.WriteLine("개의 이름: {0}, 개의 성별: {1}, 개의 주인이름: {2}", dog.GetName(), dog.GetGender(), dog.GetOwnernames());
                        }
                        break;
                }

            }

        }
    }
}
