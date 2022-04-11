using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        public string Soname, Name;
        public decimal Salary;
        string Position;
        int Expirence;
        public Employee(string soname, string name)
        {
            Soname = soname;
            Name = name;            
        }        
        public decimal CalculationSalary(string position, int expirence)
        {
            Position = position;
            Expirence = expirence;
            
            decimal PositionSalary(string Position)
            {
                switch (Position)
                {
                    case "Director":
                            return 500 * Expirence;
                    case "Manager":
                            return 250 * Expirence;
                    case "Worker":
                            return 100 * Expirence;
                    default: return 0;
                }
            }
            Salary = PositionSalary(Position) * Expirence;
            return Salary;
        }
        public decimal CalculationTax(decimal Salary)
        {
            return Salary / 100 * 13;
        }
    }
}
