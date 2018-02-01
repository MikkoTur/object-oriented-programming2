using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Vehicle uusiVehicle1 = new Vehicle("Urheilu", "Ferrari", "2015", 300000);
            uusiVehicle1.PrintInfo();

            Console.ReadKey();
        }
    }
}
