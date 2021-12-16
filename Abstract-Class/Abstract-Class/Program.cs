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
            Employee myEmployee = new Employee() {FirstName = "Sample", LastName = "Student" };

            myEmployee.SayName();

            Console.ReadLine();

        } 
    }
}
