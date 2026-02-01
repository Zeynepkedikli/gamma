//The concepts of OOP in C#
//Intro 2 encapsulation
//add static forms
using System;
using System.Collections.Generic;

namespace OopInCsharp
{
    public class Computer
    {
        private string _BIOSname;
        private string _ipadress;
        private string _OS;
        public static int counter = 0;
        public Computer(string bn, string ip, string os)
        {
            _BIOSname = bn;
            _ipadress = ip;
            _OS = os;
            counter += 1;
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

        //startComputer()
        //shutDown()
        public static void ShowComps(List<Computer> network)
        {
            for (int i = 0; i < network.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", network[i].BiosName, network[i].IpAdress, network[i].OS);
            }
        }
        public static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }

    }  //the end of tyhe class Computer


    class Program
    {

        public static void Main(string[] args)
        {

            List<Computer> net = new List<Computer>();
            int numOfComputers = 4;

            for (int i = 0; i < numOfComputers; i++)

            {
                Computer comp = new Computer("comp" + i.ToString(), "10.0.0." + Computer.getNum(), "Win10");
                net.Add(comp);
            }

            Computer.ShowComps(net);
            Console.WriteLine("We have {0} computers in our network.", Computer.counter);

        }
    }
}