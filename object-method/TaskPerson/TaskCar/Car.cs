using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar
{
    class Car
    {
        //Car info
        public string Brand;
        public double Speed;

        //Constructor

        public Car()
        {
            Brand = null;
            Speed = 0;
        }

        //Methods

        public void AskData()
        {
            Console.WriteLine($"Syötä auton merkki ja nopeus km/h: ");
            Brand = Console.ReadLine();
            Speed = int.Parse(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on: {Brand}\nAuton nopeus on: {Speed}\n");
        }

        public void Accelerate()
        {
            Console.WriteLine($"Anna kerroin jolla auton nopeuttasi lisätään: ");
            double speed1 = double.Parse(Console.ReadLine());
            if (speed1 < 1)
                Console.WriteLine($"Negatiivistä lukua ei sallita");
            else
                Console.WriteLine($"Nopeutta lisättii {speed1} kertaiseksi, uusi nopeus on {speed1 * Speed}km/h\n");

        }

    }
}
