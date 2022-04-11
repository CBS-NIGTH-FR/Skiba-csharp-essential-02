using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /*
     Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(79.65, 87.16, 0.4);
            Console.WriteLine($"конвертация 1000 руб в $ {converter.RubToForeign(1000, "usd")}");
            Console.WriteLine($"конвертация 100 евро в руб {converter.ForeignToRub(100, "eur")}");
        }
    }
}
