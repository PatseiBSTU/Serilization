using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    [DataContractAttribute]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }
        public Company() { }
        public Company(string name)
        { Name = name; }
    }

}
