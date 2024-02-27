using System.Linq.Expressions;

namespace StaffRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * I wanted two classes, one for management of employees and a second for the actual employees.
             * However, I couldn't figure out how to save the objects of the Employee-class to an array (it
             * seems a List is the better option here but I have never worked with those, or IRL the info
             * would just be saved in a DB). I prepared a simple Employee class with a constructor, but it
             * was never used and hence no support functions were added and attributes are still public.
             * Instead I saved the Employees in a string, in the form of a CSV.
             
            */

            var employees = new EmployeeManagement();
            string currentAction = "";

            Console.WriteLine("* Welcome to the Staff Register *\n");

            // In a larger app I would move this bit into a function of the EmployeeManagement class too, but it makes less sense for this tiny app
            while (currentAction.ToLower() != "x")
            {
                Console.WriteLine("Enter A to Add new employee");
                Console.WriteLine("Enter L to List all employee");
                Console.WriteLine("Enter X to Exit");
                currentAction = Console.ReadLine() ?? "";

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
