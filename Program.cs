using Microsoft.Win32.SafeHandles;
using ObjectOrientedProgrammingConceptsLibrary;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        SavingBankAccount sb1=new SavingBankAccount();
        sb1.BankAccountNo = 101;
        sb1.Balance = 100;
        sb1.Deposit(1000);
        Console.WriteLine($"Balance after deposit ={sb1.Balance}");//1100

        sb1.Withdraw(500);//600
        Console.WriteLine($"Balance after withdraw ={sb1.Balance}");
        sb1.CalculateInterest();
        Console.WriteLine($"Balance after interest calculation={sb1.Balance}");

        sb1.Deposit(10000, "Online", "1232333");
        Console.WriteLine($"Balance after deposit ={sb1.Balance}");

        //User userObj=new User();
        //Console.WriteLine("Enter username");
        //userObj.Username = Console.ReadLine();


        //Console.WriteLine($
        //"Your initial password={userObj.Password}");

        //Console.WriteLine("Enter joining date");
        //userObj.JoiningDate= Convert.ToDateTime(Console.ReadLine());
        //userObj.DisplayJoiningDate();



        //Student s = new Student();
        //Console.WriteLine("Enter rollno");
        //int r = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter student name");
        //string n = Console.ReadLine();
        //Console.WriteLine("Enter student city");
        //string c= Console.ReadLine();
        //s.AcceptData(r,n,c);
        //s.PrintData();


        //Employee emp = new Employee();
        //Console.WriteLine("Enter Employee ID");
        //emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Employee Name");
        //emp.EmployeeName = Console.ReadLine();



        //Console.WriteLine($"Entered employee id={emp.EmployeeID}");
        //Console.WriteLine($"Entered employee name={emp.EmployeeName}");

        //Console.WriteLine("Hello, World!");
        //Maths maths = new Maths();
        //int firstnumber = 100;
        //int secondnumber = 200;
        //maths.Swap(firstnumber, secondnumber);
        //Interpolation
        //Console.WriteLine($"Firstnumber in program file= {firstnumber}");
        //Console.WriteLine($"Secondnumber in program file={secondnumber}");

        //Console.WriteLine("======================");
        //maths.SwapByRef(ref firstnumber,ref secondnumber);//Address of the variable
        //Console.WriteLine($"Firstnumber in program file= {firstnumber}");
        //Console.WriteLine($"Secondnumber in program file={secondnumber}");
        //Console.WriteLine("============================");
        //int sqrtAns=maths.DoCalculation(10,out double squareAns,out double cubeAns);
        //Console.WriteLine($"Square Root={sqrtAns}");
        //Console.WriteLine($"Square ={squareAns}");
        //Console.WriteLine($"Square Root={cubeAns}");
        //Console.WriteLine("----------------------------");
        //Circle c=new Circle();
        //decimal circumference=c.CalculatePerimeter(10);
        //Console.WriteLine($"Circle Perimeter/Circumference= {circumference}");
        //circumference = c.CalculatePerimeter(0,20);
        //Console.WriteLine($"Circle Perimeter/Circumference= {circumference}");

        //circumference = c.CalculatePerimeter();
        //Console.WriteLine($"Circle Perimeter/Circumference= {circumference}");


        //Circle c1 = new Circle { };//Object initializer,
        ////Calls default constructor unless properties are initialized in the curly brackets
        //circumference = c1.CalculatePerimeter(10);
        //Console.WriteLine($"Circle Perimeter/Circumference= {circumference}");



        //Circle c2 = new();//Target typed new expression/Target typed new, calls default constructor
        //circumference = c2.CalculatePerimeter(10);
        //Console.WriteLine($"Circle Perimeter/Circumference= {circumference}");


    }
}