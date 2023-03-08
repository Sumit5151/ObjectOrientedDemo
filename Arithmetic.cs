using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Arithmetic
    {

        public int A { get; set; }
        public int B { get; set; }



        public void Add(int num1, int num2)  // parameters or arguments  
        {
            int result = num1 + num2;

            //Console.WriteLine("Addition of " + num1 + " and " + num2 + "is = " + result);
            Console.WriteLine($"Addition of  {num1}  and   {num2}  is =  {result}");

            //Addition of 10 and 20 is = 30
        }



        //function complex argumets or paramters
        public void Sub(Arithmetic arth)
        {
            int result = arth.A - arth.B;

            Console.WriteLine($"Substraction of  {arth.A}  and   {arth.B}  is =  {result}");
        }





        public void Mul(int num1, int num2, out int result)  // output parameter
        {
             result = num1 * num2;
        }



        public void Div(int num1, int num2, ref int result1)  //input-output parameter
        {
            result1 = result1 + num1 / num2;          
            
        }

    }
}
