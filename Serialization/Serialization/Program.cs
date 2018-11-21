using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            // объект для сериализации
            Point center = new Point(23, 0);
            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("pointsbin.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, center);
            }

            // десериализация 
            using (FileStream fs = new FileStream("pointsbin.dat", FileMode.OpenOrCreate))
            {
                Point newPoint = (Point)formatter.Deserialize(fs);

                Console.WriteLine($"X: {newPoint.x} , Y: {newPoint.y}");
            }

        }
    }
}
