using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer person1 = new Programmer("Anna", 21, new Company("OOO"));
            Programmer person2 = new Programmer("Nikita", 45, new Company("OAO"));
            Programmer[] people = new Programmer[] { person1, person2 };

            DataContractJsonSerializer jsonFormatter =
                         new DataContractJsonSerializer(typeof(Programmer[]));

            using (FileStream fs = new FileStream("programmers.json",
                                           FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }

            using (FileStream fs = new FileStream("programmers.json",
                                                    FileMode.OpenOrCreate))
            {
                Programmer[] newpeople =
                        (Programmer[])jsonFormatter.ReadObject(fs);

            }

        }
    }
}
