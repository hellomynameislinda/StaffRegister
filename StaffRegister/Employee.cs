using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegister
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string employeeName, double employeeSalary)
        {
            Name = employeeName;
            Salary = employeeSalary;
        }
    }
}





