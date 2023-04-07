using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1.ClassTest
{
    class Dog
    {
        private string name; // 개의 이름을 나타내는 필드
        private string gender; // 개의 성별을 나타내는 필드
        private string ownernames; // 개의 주인 이름을 나타내는 필드

        public void SetDog(string name, string gender, string ownernames)
        {
            this.name = name;
            this.gender = gender;
            this.ownernames = ownernames;
        }

        public string GetName()
        {
            return this.name;
            this.gender = gender;
            this.ownernames = ownernames;
        }

        public string GetGender()
        {
            return this.gender;
        }

        public string GetOwnernames()
        {
            return this.ownernames;
        }

        public void Bark() // 짖는 행동
        {
            Console.WriteLine("{0} : 멍멍!", name);
        }
    }
}
