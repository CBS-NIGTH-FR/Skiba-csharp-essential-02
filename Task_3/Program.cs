using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    /*Создать класс Employee.
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
инициализирует поля, соответствующие фамилии и имени сотрудника.
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый
сбор.
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
оклад и налоговый сбор.*/
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Skiba", "Ilya");
            Console.WriteLine(employee.Name+ " "+employee.Soname);
            Console.WriteLine(employee.CalculationSalary("Director", 3));
            Console.WriteLine(employee.CalculationTax(employee.Salary));
        }
    }
}
