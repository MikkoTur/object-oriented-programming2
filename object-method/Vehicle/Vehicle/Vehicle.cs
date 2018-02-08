using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        public string Type;
        public string Brand;
        public string Year;
        public double Price;

        //Constructor

        public Vehicle(string type, string brand, string year, double price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        public Vehicle()
        {
            Type = "Ei tiedoissa";
            Brand = "Ei tiedoissa";
            Year = "Ei tiedoissa";
            Price = 0;
        }

        public virtual string PrintInfo()
        {
           return $"Auton tyyppi: {Type}\n" +
                $"Auton merkki: {Brand}\n" +
                $"Vuosimalli: {Year}\n" +
                $"Hinta: {Price:C}";
        }
    }
}
