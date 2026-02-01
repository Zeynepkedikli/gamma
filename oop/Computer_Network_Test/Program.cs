using System;

namespace ComputerNetwork
{
    class PCTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== PC Test ===");
            PC test1 = new PC("192.168.1.1", "HP", "Windows", false);
            Console.WriteLine("IP: {0}, Brand: {1}", test1.Ip, test1.Brand);

            Console.WriteLine("\n=== Turn On/Off Test ===");
            test1.TurnOn();
            Console.WriteLine("Status: {0}", test1.GetStatus());
            test1.TurnOff();
            Console.WriteLine("Status: {0}", test1.GetStatus());

            Console.WriteLine("\n=== Counter Test ===");
            PC pc1 = new PC("10.0.0.1", "Dell", "Linux", false);
            PC pc2 = new PC("10.0.0.2", "Lenovo", "Windows", false);
            Console.WriteLine("Total: {0}", PC.GetTotal());

            pc1.TurnOn();
            pc2.TurnOn();
            Console.WriteLine("Online: {0}", PC.GetOnline());

            Console.WriteLine("\n=== Server Test ===");
            ServerPC srv = new ServerPC("10.0.0.50", "Dell", "Linux", false, "File Server");
            Console.WriteLine("Server IP: {0}, Role: {1}", srv.Ip, srv.Role);

            DesignPC dpc = new DesignPC("10.0.0.60", "HP", "Windows", false, "AutoCAD");
            Console.WriteLine("Design PC IP: {0}, App: {1}", dpc.Ip, dpc.App);
        }
    }
}