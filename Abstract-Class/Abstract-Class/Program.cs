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
            };

            myEmployee1.Things = new List<string>() { "car", "truck", "semi" };


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
            };

            myEmployee3.Things = new List<int>() { 1, 2, 3 };

            myEmployee1.SayName();

            Console.WriteLine("myEmployee1 things:");
            foreach (string thing in myEmployee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("myEmployee3 things:");
            foreach (int thing in myEmployee3.Things)
            {
                Console.WriteLine(thing);
            }


            //Console.WriteLine(myEmployee1 == myEmployee3);



            myEmployee2.Quit();

            Console.Write("Hired Status: " + myEmployee2.Hired);


            Console.ReadLine();

        } 
    }
}
