using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Invoice
    {
        public readonly int account; // счёт
        public readonly string customer, provider; // покупатель, поставщик
        public double price;
        const double VAT = 1.2;
        public Invoice(int _account, string _customer, string _provider)
        {
            account = _account;
            customer = _customer;
            provider = _provider;
        }
        double Price(string article)
        {
            switch (article)
            {
                case "boots":
                    return 20.50;
                case "dress":
                    return 324.90;
                case "shirt":
                    return 275;
                default:
                    Console.WriteLine("Неверное наименование");
                    return 0;
            }
        }
        public double CalculationCost(string article, int quantity)
        {
            price = Price(article)*quantity;
            return price;
        }
        public double CalculationCostWithVAT(string article, int quantity) 
        {
            price = Price(article) * quantity;
            price *= VAT;
            return price;
        }
    }
}
