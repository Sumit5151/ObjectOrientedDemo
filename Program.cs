using ObjectOrientedDemo;

public class Program
{

    public static void Main()
    {


        int num1 = 10;
        int num2 = 20;


        CallByValueCallByReference callByValueCallByReference = new CallByValueCallByReference();

        Console.WriteLine("call by value Before calling to function");
        Console.WriteLine($"Nubmer1 ={num1} Number2 = {num2}");

        callByValueCallByReference.CallByValue(num1,num2);

        Console.WriteLine("call by value After calling to function");
        Console.WriteLine($"Nubmer1 ={num1} Number2 = {num2}");



        Console.WriteLine("call by Reference Before calling to function");
        Console.WriteLine($"Nubmer1 ={num1} Number2 = {num2}");

        callByValueCallByReference.CallByReference(ref num1,ref num2);

        Console.WriteLine("call by Reference After calling to function");
        Console.WriteLine($"Nubmer1 ={num1} Number2 = {num2}");








        //  Arithmetic arithmetic1 = new Arithmetic();
        //  arithmetic1.A = 20;
        //  arithmetic1.B = 10;



        //  Arithmetic arithmetic2 = new Arithmetic();
        //  arithmetic2.Sub(arithmetic1);








        //  arithmetic1.Add(10, 20);

        //  int result;
        //  int num1 = 10, num2 = 20;

        //  //Actual parameter
        //  arithmetic2.Mul(num1, num2, out result); 
        //  Console.WriteLine($"Multiplication of  10  and   20  is =  {result}");


        //  int resultnew = 10;
        //  arithmetic2.Div(num1, num2, ref resultnew);

        //  Console.WriteLine($"Result =  {resultnew}");


        //  int modeRusult = arithmetic2.Mod(5, 2);
        //  Console.WriteLine($"Mod of two numbers = " + modeRusult);


        //int additionResult =   arithmetic2.ArithmaticOperation(10, 20, out int substrationResult, 
        //                                              out int multiplicationResult, out int divisionResult,
        //                                              out int modResult);

        //  Console.WriteLine($"Addition = {additionResult} substraction ={substrationResult}" +
        //                    $"mulitiplication = {multiplicationResult} division ={divisionResult} mod={modResult}");










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
