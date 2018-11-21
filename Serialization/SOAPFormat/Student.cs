using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPFormat
{
    [Serializable]
    class Student
    {
        private String name;
        private int age;
        [NonSerialized]
        private String adress;

        public Student(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
        }
    }

}
