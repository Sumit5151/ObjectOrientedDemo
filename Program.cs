using ObjectOrientedDemo;

public class Program
{

    public static void Main()
    {


        Arithmetic arithmetic1 = new Arithmetic();
        arithmetic1.A = 20;
        arithmetic1.B = 10;



        Arithmetic arithmetic2 = new Arithmetic();
        arithmetic2.Sub(arithmetic1);








        arithmetic1.Add(10,20);
        int result;

        arithmetic2.Mul(10, 20, out result);
        Console.WriteLine($"Multiplication of  10  and   20  is =  {result}");

        int result1=10;
        arithmetic2.Div(20,10, ref result1);
        Console.WriteLine($"Result =  {result1}");















        //Console.WriteLine("doctor1 object");
        //Doctor doctor1 = new Doctor();        
        //doctor1.GetData();
        //doctor1.PutData();


        //Console.WriteLine("doctor2 object");
        //Doctor doctor2 = new Doctor();
        //doctor2.GetData();
        //doctor2.PutData();




        //int i=0;
        //float j=2.1f;
        //string k = "watch";
        //Doctor doctor3 = new Doctor(); ;

        //doctor3.Id++;

        //i++;
        //j++;






        //Doctor.TypeCastingDemo();


        //Console.WriteLine("Employee1 object inforation");
        //Employee employee1 = new Employee();
        //employee1.GetData();
        //employee1.PutData();


        //Console.WriteLine("Employee2 object inforation");
        //Employee employee2 = new Employee();
        //employee2.GetData();
        //employee2.PutData();


        //Console.WriteLine("Employee3 object inforation");
        //Employee employee3 = new Employee();
        //employee3.GetData();
        //employee3.PutData();




        //CreateDemoObject();

    }

    public void CreateDemoObject()
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
