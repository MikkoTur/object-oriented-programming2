using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle
    {
        protected double KoneenKoko;
        protected string Malli;
        protected int OvienLkm;

        public Car(double koneenkoko, string malli, int ovienlkm)
        {
            KoneenKoko = koneenkoko;
            Malli = malli;
            OvienLkm = ovienlkm;
        }

        public override string PrintInfo()
        {
            return $"Koneen koko: {KoneenKoko}\n" +
                $"Malli: {Malli}\n" +
                $"Ovien lukumäärä {OvienLkm}\n";
        }

        public override string ToString()
        {
            return PrintInfo();
        }

        public override bool Equals(object obj)
        {
            return (KoneenKoko> ((Car)obj).KoneenKoko);
        }
    }
}
