using System;
using System.Collections.Generic;

namespace ComputerNetwork
{
    public class PC
    {
        private string ip;
        private string brand;
        private string system;
        private bool isOn;

        private static int totalPCs = 0;
        private static int onlinePCs = 0;

        public PC(string ipAddress, string maker, string os, bool status)
        {
            this.Ip = ipAddress;
            this.Brand = maker;
            this.System = os;
            this.IsOn = status;
            totalPCs++;
        }

        public PC()
        {
            totalPCs++;
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string System
        {
            get { return system; }
            set { system = value; }
        }

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public static int GetTotal()
        {
            return totalPCs;
        }

        public static int GetOnline()
        {
            return onlinePCs;
        }

        public void TurnOn()
        {
            this.IsOn = true;
            onlinePCs++;
            Console.WriteLine("PC {0} is starting...", this.Ip);
        }

        public void TurnOff()
        {
            this.IsOn = false;
            onlinePCs--;
            Console.WriteLine("PC {0} is shutting down...", this.Ip);
        }

        public string GetStatus()
        {
            return this.IsOn ? "ON" : "OFF";
        }
    }

    public class ServerPC : PC
    {
        private string role;

        public ServerPC(string ipAddress, string maker, string os, bool status, string serverRole)
            : base(ipAddress, maker, os, status)
        {
            this.Role = serverRole;
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }

    public class DesignPC : PC
    {
        private string app;

        public DesignPC(string ipAddress, string maker, string os, bool status, string application)
            : base(ipAddress, maker, os, status)
        {
            this.App = application;
        }

        public string App
        {
            get { return app; }
            set { app = value; }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<PC> computers = new List<PC>();

            ServerPC server1 = new ServerPC("10.0.0.10", "Dell", "Linux", false, "WEB Server");
            PC comp1 = new PC("10.0.0.11", "Dell", "Windows", false);
            PC comp2 = new PC("10.0.0.12", "Lenovo", "Linux", false);
            PC comp3 = new PC("10.0.0.15", "HP", "Windows", false);
            PC comp4 = new PC("10.0.0.16", "Dell", "Windows", false);
            DesignPC design1 = new DesignPC("10.0.0.17", "Dell", "Windows", false, "Photoshop");

            computers.Add(server1);
            computers.Add(comp1);
            computers.Add(comp2);
            computers.Add(comp3);
            computers.Add(comp4);
            computers.Add(design1);

            Console.WriteLine("Total PCs: {0}\n", PC.GetTotal());

            for (int i = 0; i < computers.Count; i++)
            {
                computers[i].TurnOn();
            }

            Console.WriteLine("--------------------------------------------------------------------\n");
            Console.WriteLine("Online PCs: {0}\n", PC.GetOnline());

            foreach (PC pc in computers)
            {
                if (pc.IsOn)
                {
                    Console.Write("{0}\t{1}\t\t{2}\t", pc.Ip, pc.System, pc.Brand);

                    Type pcType = pc.GetType();
                    string name = pcType.ToString();
                    int pos = name.IndexOf('.');
                    string shortName = name.Substring(pos + 1, 4);
                    Console.Write(shortName);

                    string details = "";
                    if (shortName == "Serv")
                    {
                        details = server1.Role;
                        Console.WriteLine("\t{0}", details);
                    }
                    else if (shortName == "Desi")
                    {
                        details = design1.App;
                        Console.WriteLine("\t{0}", details);
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("--------------------------------------------------------------------\n");
            server1.TurnOff();
            Console.WriteLine("\nOnline PCs: {0}\n", PC.GetOnline());

            foreach (PC pc in computers)
            {
                if (pc.IsOn)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}", pc.Ip, pc.System, pc.Brand);
                }
            }

            Console.WriteLine("--------------------------------------------------------------------\n");

            Random rnd = new Random();
            double time;
            PC myPC = comp1;
            string targetIP = "10.0.0.12";
            bool exists = false;

            foreach (PC pc in computers)
            {
                if (targetIP == pc.Ip && pc.IsOn == true)
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                for (int i = 5; i < 15; i++)
                {
                    time = (float)(rnd.Next(1, 100)) / 100;
                    Console.WriteLine("64 bytes from {0} icmp_seq={1} ttl=64 time={2} ms",
                        myPC.Ip, i.ToString(), time.ToString());
                }
            }
            else
            {
                Console.WriteLine("Address {0} not found!", targetIP);
            }
        }
    }
}