using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /*Создать класс Invoice.
В теле класса создать три поля int account, string customer, string provider, которые должны
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их
дальнейшего изменения.
В теле класса создать два закрытых поля string article, int quantity
Создать метод расчета стоимости заказа с НДС и без НДС.
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.*/
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(235, "Skiba", "Skyfor");
            Console.WriteLine(invoice.account+" "+invoice.customer+" "+invoice.provider);
            Console.WriteLine(invoice.CalculationCost("dress", 8));
            Console.WriteLine(invoice.CalculationCostWithVAT("dress", 8));
        }
    }
}
