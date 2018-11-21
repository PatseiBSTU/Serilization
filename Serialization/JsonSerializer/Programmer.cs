using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    [DataContract]
    public class Programmer
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public Company Company { get; set; }
        public Programmer()
        { }
        public Programmer(string name, int age, Company comp)
        {
            Name = name;
            Age = age;
            Company = comp;
        }
    }

}
