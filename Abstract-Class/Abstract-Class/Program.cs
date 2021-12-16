using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee() {FirstName = "Sample", LastName = "Student", Hired = true};

            IQuittable myEmployee2 = new Employee() { FirstName = "Sample", LastName = "Student", Hired = true };

            myEmployee.SayName();

            myEmployee2.Quit();

            Console.Write("Hired Status: " + myEmployee2.Hired);

            Console.ReadLine();

        } 
    }
}
