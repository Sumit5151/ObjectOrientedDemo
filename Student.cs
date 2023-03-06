using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class Student
    {
        
        int num1 { get; set; } //Defalutl value  0
        int num2 { get; set; }
        int result { get; set; }    
        string name { get; set; }//default value =null
        
        
        
        //Parameter less method
        public void SumOfInterger()
        {



            result= num1 + num2;
        }
    }
}
