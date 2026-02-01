//The concepts of OOP in C#
//Intro 2 encapsulation
using System;
using System.Collections.Generic;
namespace OopInCsharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
        }


        public string BiosName
        {
            get { return _BIOSname; }
            set { _BIOSname = value; }
        }

        public string IpAdress
        {
            get { return _ipadress; }
            set { _ipadress = value; }
        }

        public string OS
        {
            get { return _OS; }
            set { _OS = value; }
        }



    }  //the end of tyhe class Computer
    class Program
    {
        public static void Main(string[] args)
        {
            List<Computer> net = new List<Computer>();
            int numOfComputers = 5;

            for (int i = 0; i < numOfComputers; i++)

            {
                Computer comp = new Computer("comp" + i.ToString(), "10.0.20." + i.ToString(), "Win10");
                net.Add(comp);
            }


            //display objects Computer        
            for (int i = 0; i < net.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", net[i].BiosName, net[i].IpAdress, net[i].OS);
            }

        }
    }
}