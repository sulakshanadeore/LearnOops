using ObjectOrientedProgrammingConceptsLibrary;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {

        Student s = new Student();
        Console.WriteLine("Enter rollno");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student name");
        string n = Console.ReadLine();
        Console.WriteLine("Enter student city");
        string c= Console.ReadLine();
        s.AcceptData(r,n,c);
        s.PrintData();


        Employee emp = new Employee();
        Console.WriteLine("Enter Employee ID");
        emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        emp.EmployeeName = Console.ReadLine();



        Console.WriteLine($"Entered employee id={emp.EmployeeID}");
        Console.WriteLine($"Entered employee name={emp.EmployeeName}");

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