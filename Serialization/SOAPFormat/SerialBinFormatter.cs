
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;

// Note: When building this code, you must reference the
// System.Runtime.Serialization.Formatters.Soap.dll assembly.

namespace SOAPFormat
{

    static class SerialBinFormatter
    {
        public static void SaveBinaryFormat(object obj, string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create,
                    FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, obj);
            }
        }
        static void LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(fileName))
            {
                Student Olga =
                     (Student)binFormat.Deserialize(fStream);

            }
        }
        public static void SoapWriteFile(object objGraph, string fileName)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormatter.Serialize(fStream, objGraph);
            }
        }


    }
}