﻿using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Vehicle uusiVehicle1 = new Vehicle("Sedan", "BMW", "2015", 70000);
            Car uusiAuto1 = new Car(2.0, "520", 5);

            Vehicle uusiVehicle2 = new Vehicle("Sedan", "Nissan", "2012", 35000);
            Car uusiAuto2 = new Car(1.8, "Ultimate", 5);

            Console.WriteLine(uusiVehicle1.PrintInfo());
            Console.Write(uusiAuto1.ToString()+"\n");

            Console.WriteLine(uusiVehicle2.PrintInfo());
            Console.Write(uusiAuto2.ToString()+"\n");


            Console.WriteLine($"Onko BMW moottori isompi kuin Nissanin {uusiAuto1.Equals(uusiAuto2)}");

            Console.ReadKey();
        }
    }
}
