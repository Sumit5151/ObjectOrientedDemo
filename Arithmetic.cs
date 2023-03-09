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




        //formal parameter
        public void Mul(int a, int b, out int result)  // output parameter
        {            
            result = a * b;           
        }



        public void Div(int a, int b, ref int resultnew)  //input-output parameter
        {
            resultnew = resultnew + b / a;                  
            
        }


        public int Mod(int num1, int num2)
        {
            int result = num1 % num2;
            return result;
        }


        public int ArithmaticOperation(int a, int b, out int substractionResult,
                                                   out int miltiplicationResult, out int divisionResult,
                                                   out int modResult)
        {
            int additionResult = a + b;
             substractionResult = a - b;
             miltiplicationResult = a * b;
             divisionResult = a / b;
             modResult = a % b;


            return additionResult;
        }
    }
}
