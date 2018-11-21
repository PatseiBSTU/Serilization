using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Point dot = new Point(10, 100);
            // передаем в конструктор тип класса
            XmlSerializer xSer = new XmlSerializer(typeof(Point));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("points.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fs, dot);
            }

            // десериализация
            using (FileStream fs = new FileStream("points.xml", FileMode.OpenOrCreate))
            {
                Point newP = xSer.Deserialize(fs) as Point;
                Console.WriteLine(newP.ToString());
            }

            //------------------------------------------------
            var studentAnna = new StudentBSTU { Name = "Anna", Mark = 9.1 };
            var ds = new DataContractSerializer(typeof(StudentBSTU));
            using (Stream s = File.Create("stud.xml"))
            {
                ds.WriteObject(s, studentAnna);
            }
            using (Stream s = File.Open("stud.xml", FileMode.Open))
            {
                StudentBSTU newStud = (StudentBSTU)ds.ReadObject(s);
            }

        }
    }
}
