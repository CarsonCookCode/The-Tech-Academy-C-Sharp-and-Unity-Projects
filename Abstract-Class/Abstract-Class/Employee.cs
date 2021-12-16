using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable
    {
        public bool Hired { get; set; }
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);

           
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {

            return employee1.Equals(employee2.Id);
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {

            return !(employee1.Equals(employee2.Id));
        }


        public void Quit()
        {
            Hired = false;
        }
    }
}
