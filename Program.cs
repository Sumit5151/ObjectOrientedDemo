﻿using ObjectOrientedDemo;

public class Program
{

    public static void Main()
    {

        Console.WriteLine("Employee1 object inforation");
        Employee employee1 = new Employee();
        employee1.GetData();
        employee1.PutData();


        Console.WriteLine("Employee2 object inforation");
        Employee employee2 = new Employee();
        employee2.GetData();
        employee2.PutData();


        Console.WriteLine("Employee3 object inforation");
        Employee employee3 = new Employee();
        employee3.GetData();
        employee3.PutData();




        //CreateDemoObject();

    }



    public static void CreateDemoObject()
    {
        Employee object1 = new Employee(); // instance of the class

        object1.Id = 10;
        object1.Name = "Amit";
        object1.Address = "Pune";


        //Console.WriteLine($"Object1 information Id= {object1.Id}");
        Console.WriteLine("Object1 information Id= " + object1.Id);
        Console.WriteLine("Name= " + object1.Name);
        Console.WriteLine("Address= " + object1.Address);


        Employee object2;    //class variable
        object2 = new Employee(); // class instance


        object2.Id = 20;
        object2.Name = "Vijay";
        object2.Address = "Mumbai";


        //Console.WriteLine($"Object1 information Id= {object1.Id}");
        Console.WriteLine("object2 information Id= " + object2.Id);
        Console.WriteLine("Name= " + object2.Name);
        Console.WriteLine("Address= " + object2.Address);




        Employee employee = new Employee();

        Console.WriteLine("Please Enter the value for employee id");
        employee.Id = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please Enter the Value for employee Name");
        employee.Name = Console.ReadLine();

        Console.WriteLine("Please Enter the Value for employee Address");
        employee.Address = Console.ReadLine();



        Console.WriteLine("employee information Id= " + employee.Id);
        Console.WriteLine("Name= " + employee.Name);
        Console.WriteLine("Address= " + employee.Address);
    }

}