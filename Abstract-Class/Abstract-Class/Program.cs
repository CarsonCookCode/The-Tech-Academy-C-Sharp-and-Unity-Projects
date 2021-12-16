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

            Employee<string> myEmployee1 = new Employee<string>() 
            { 
                FirstName = "Sample",
                LastName = "Student",
                Hired = true,
                Id = 1,
                //Things = {"Stapler", "Paper"}
            };

            IQuittable myEmployee2 = new Employee<Person>() 
            { 
                FirstName = "Sample",
                LastName = "Student",
                Hired = true,
                Id = 2 
            };

            Employee<int> myEmployee3 = new Employee<int>() 
            { 
                FirstName = "Sample",
                LastName = "Student",
                Hired = true,
                Id = 3,
                //Things = { 1, 2, 3 } 
            };

            myEmployee1.SayName();


            Console.WriteLine(myEmployee1 == myEmployee3);



            myEmployee2.Quit();

            Console.Write("Hired Status: " + myEmployee2.Hired);


            Console.ReadLine();

        } 
    }
}
