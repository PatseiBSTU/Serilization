using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [StructLayout(LayoutKind.Sequential)]
   public struct SYSTEMTIME
    {
        public ushort wYear;
        public ushort wMonth;
        public ushort wDayOfWeek;
        public ushort wDay;
        public ushort wHour;
        public ushort wMinute;
        public ushort wSecond;
        public ushort wMilliseconds;
    }


    [System.AttributeUsage(AttributeTargets.Class |
                 AttributeTargets.Method,
                 AllowMultiple = true)]

    public class BSTUAttribute : System.Attribute
    {
        public string Name { get; private set; }
        public int Version { get; set; }

        public BSTUAttribute(string name)
        {
            Name = name;
        }
    }
    [BSTU("OOP C++/C#", Version = 3)]
    public class Book
    {
        [DllImport("kernel32.dll")]

        public static extern void GetLocalTime(ref SYSTEMTIME st);
        [BSTU("Draft")]
        public void Print() { }
    }

    // применение атрибута к сборке
    // [assembly: AssemblyKeyFile("keys.snk")] 

    // многократное применение атрибута 
    [BSTU("Serialization"), BSTU("Lecture 12")]
    public class Presentation { }
}

class Program
    {
        static void Main(string[] args)
        {
        }
    }
 
