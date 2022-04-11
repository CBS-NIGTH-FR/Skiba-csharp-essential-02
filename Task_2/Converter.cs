using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Converter
    {
        double Usd, Eur, Grn;
        public Converter(double usd, double eur, double grn)
        {
            Usd = usd;
            Eur = eur;
            Grn = grn;
        }

        public double RubToForeign(double amount, string currency)
        {

            switch (currency)
            {
                case "usd":
                    return amount / Usd;

                case "eur":
                    return amount / Eur;

                case "rub":
                    return amount / Grn;
                default:
                    Console.WriteLine("Ошибка выбора валюты");
                    return 0;

            }
        }
        public double ForeignToRub(double amount, string currency)
        {
            switch (currency)
            {
                case "usd":
                    return amount * Usd;

                case "eur":
                    return amount * Eur;

                case "grn":
                    return amount * Grn;
                default:
                    Console.WriteLine("Ошибка выбора валюты");
                    return 0;
            }
        }
    }
}
