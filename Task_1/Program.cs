using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /*
     Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
Реализуйте вывод на экран информации о пользователе.
     */
    class Program
    {
        static void Main(string[] args)
        {
            User myPerson = new User();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите ваш логин");
            myPerson.login = Console.ReadLine();
            Console.WriteLine("Введите ваше имя");
            myPerson.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            myPerson.soname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            myPerson.age = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Логин: "+myPerson.login + "\nФамилия " + myPerson.soname + " имя " + myPerson.name + " возраст "+ myPerson.age + " дата регистрации " + myPerson.Data_of_registr.ToString("D"));
        }
    }
}
