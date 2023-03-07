using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Doctor
    {       
        public int Id { get; set; }       
        public string Name { get; set; }
        public int GrossIncome { get; set; }
        public int IncomeTax { get; set; }
        public int NetIncome { get; set; }

        //non value returning function
        public void GetData()
        {
            Console.WriteLine("Please enter the value for Id");
            Id =  Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Please enter the value for Name");
            Name = Console.ReadLine();


            Console.WriteLine("Please enter the value for GrossIncome");
            GrossIncome = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the value for IncomeTax");
            IncomeTax = Convert.ToInt32(Console.ReadLine());


            NetIncome = CalculagteNetIncome();

        }


        //non value returning function   witout return type
        public void PutData()
        {
            Console.WriteLine("Id =" + Id);
            Console.WriteLine("Name =" + Name);
            Console.WriteLine("GrossIncome =" + GrossIncome);
            Console.WriteLine("IncomeTax =" + IncomeTax);
            Console.WriteLine("NetIncome =" + NetIncome);
        }

        //value returning method  
        public int CalculagteNetIncome()
        {
            int result=  GrossIncome - IncomeTax;
            return result;
        }


        #region Type casting demo
        //Type casting demo
        public string strId { get; set; }
        public char charId { get; set; }
        public static void TypeCastingDemo()
        {

            Doctor doctor = new Doctor(); 

            doctor.strId = "10";
            doctor.Id = Convert.ToInt32(doctor.strId);   //explicite type casting

            doctor.charId = 'A';
            doctor.Id = doctor.charId; //Implicite type casting

        }
        #endregion


    }
}
