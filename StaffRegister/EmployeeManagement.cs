using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegister
{
    internal class EmployeeManagement
    {
        private string AllEmployees { get; set; } = "Name, Salary\n";

        public void AddEmployee()
        {
            string name = "";
            string salaryText = "";
            double salary = 0;

            Console.WriteLine("Add Employee");
            
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine() ?? "";

            Console.WriteLine("Enter employee salary:");
            salaryText = Console.ReadLine() ?? "";
            while (!double.TryParse(salaryText, out salary)) {
                Console.WriteLine("Error: Salary not a number, will be saved as zero.");
                Console.WriteLine("Enter employee salary:");
                salaryText = Console.ReadLine() ?? "";
            }

            AllEmployees += name + ", " + salary + "\n"; // Saving employees one user per row, comma separated.

            Console.WriteLine("Employee saved\n");
        }

        public void ListAllEmployees()
        {
            Console.WriteLine("List All Employees");
            Console.WriteLine(AllEmployees + "\n");
        }
    }
}
