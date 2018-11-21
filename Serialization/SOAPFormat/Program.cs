using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Leha = new Student("Leha", 19, "Minsk, Sverdloava 13");

            // Сохранить объект в указанном файле в двоичном формате
            SerialBinFormatter.SaveBinaryFormat(Leha, "BinData.dat");
            SerialBinFormatter.SoapWriteFile(Leha, "SoapData.dat");


        }
    }
}
