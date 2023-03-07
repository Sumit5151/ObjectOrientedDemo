using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Employee
    {
        //members of the class
        //Data members
        public Nullable<int> Id { get; set; }
        public string RollNumber { get; set; } 
        public int salary { get; set; }
        public char? ch { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public object AdharCardNumber { get; set; } 

        //Member functions

        public void GetData()
        {
            ch = null;
            Id = null;

            Name = null;

            AdharCardNumber = 222;

            int result = 10 + Convert.ToInt32( AdharCardNumber);

            //Unboxing 

            RollNumber = Convert.ToString(Id);  //converting from value type to reference type   //boxing 
            Id = Convert.ToInt32( RollNumber);  //converting from reference type to value type


            Employee employee = new Employee();
            employee.GetData();

            Console.WriteLine("Please Enter the value for employee id");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Value for employee Name");
            this.Name = Console.ReadLine();

            Console.WriteLine("Please Enter the Value for employee Address");
            this.Address = Console.ReadLine();

        }

        public static void CreateObject()
        {
            Employee employee = new Employee();
            
        }
        public static void CreateObject2()
        {
            Employee employee = new Employee();
            int lmn;
        }

        public void PutData()
        {

            int xyz;
            Console.WriteLine("Id= " + this.Id);
            Console.WriteLine("Name= " + this.Name);
            Console.WriteLine("Address= " + this.Address);
        }



    }
}
