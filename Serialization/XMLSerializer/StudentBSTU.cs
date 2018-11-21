using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializer
{
    public class StudentBSTU
    {
        [XmlAttribute("fullname")]
        public string Name { get; set; }

        [XmlIgnore]
        public double Mark { get; set; }
    }

    [XmlRoot("BSTU")]
    public class Group
    {
        [XmlArray("Isit")]
        [XmlArrayItem("studentBSTU")]
        public List<StudentBSTU> List { get; set; }
    }
}
