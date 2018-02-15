using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class KuormaAuto : Car
    {
        private double _kuormanPaino;
        private double _kulutusPerKg;

        protected double KuormanPaino { get => _kuormanPaino; set => _kuormanPaino = value; }
        protected double KulutusPerKg { get => _kulutusPerKg; set => _kulutusPerKg = value; }

        public KuormaAuto(double koneenkoko, string malli, int ovienlkm, double kuormanpaino, double kulutusperkg) : base(koneenkoko, malli, ovienlkm)
        {
            KuormanPaino = kuormanpaino;
            KulutusPerKg = kulutusperkg;
        }

        public string CalcCons()
        {
            double cons = _kuormanPaino / _kulutusPerKg;
            return ($"Kulutus on {cons} litraa");
        }
    }
}
