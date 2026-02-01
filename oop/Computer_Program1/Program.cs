//The concepts of OOP in C#
using System;
namespace OOP_in_Csharp
{
    public class Computer
    {
        public string _BIOSname;
        public string _ipadress;
        public string _OS;
        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Computer comp1 = new("alfa", "10.0.0.23", "Windows 11");
            Console.WriteLine(comp1._BIOSname);
        }
    }
}