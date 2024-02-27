using System.Linq.Expressions;

namespace StaffRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var employees = new EmployeeManagement();
            string currentAction = "";

            Console.WriteLine("* Welcome to the Staff Register *\n");

            while (currentAction.ToLower() != "x")
            {
                Console.WriteLine("Enter A to Add new employee");
                Console.WriteLine("Enter L to List all employee");
                Console.WriteLine("Enter X to Exit");
                currentAction = Console.ReadLine() ?? "";

                // This could also be made into a function of the EmployeeManagement class
                switch (currentAction.ToLower())
                {
                    case "a":
                        employees.AddEmployee();
                        break;
                    case "l":
                        employees.ListAllEmployees();
                        break;
                    case "x":
                        Console.WriteLine("The app will close down.");
                        break;
                    default:
                        // Nothing
                        break;
                }

                

            }

        }
    }
}
