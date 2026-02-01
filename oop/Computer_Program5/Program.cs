//The concepts of OOP in C#
//Intro 6 encapsulation
//overloading
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

        public Computer(string bn, string os)
        {
            _BIOSname = bn;
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


        public void StartComputer(string num)
        {
            IpAdress = num;
            counter += 1;
        }

        public static void ShowComps(List<Computer> network)
        {
            for (int i = 0; i < network.Count; i++)
            {
                Console.WriteLine("{0} {1}", network[i].BiosName, network[i].IpAdress);
            }
        }

    }  //the end of tyhe class Computer
    class Program
    {

        static string getNum()
        {
            Random random = new Random();
            int num;
            num = random.Next(1, 255);
            return num.ToString();
        }


        public static void Main(string[] args)
        {

            List<Computer> net = new List<Computer>();

            int numOfComputers = 4;
            for (int i = 0; i < numOfComputers; i++)

            {
                Computer comp = new Computer("comp" + i.ToString(), "10.0.0." + getNum(), "Win10");
                net.Add(comp);
            }


            Computer.ShowComps(net);
            Console.WriteLine("We have {0} computers in our network.", Computer.counter);

            //We start a new computer
            Computer newComp = new Computer("new", "Win10");
            net.Add(newComp);
            newComp.StartComputer("10.0.0." + getNum());

            //IT, Math, Physics    
            Computer.ShowComps(net);
            Console.WriteLine("We have {0} computers in our network.", Computer.counter);



        }
    }
}