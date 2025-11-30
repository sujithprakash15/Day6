class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public decimal Salaray { get; set; }
    private string location;
    public string location
    {
        get => location; // Expression-bodied get accessor
        set { location = value; } // Expression-bodied set accessor
    }
    
    //printing

    public void DisplayDetails() => Console.WriteLine($"{EmpId}, {EmpName}");
}
class Program
{
    static Func<int, int> Square = x => x*x;
    static void Main()
    {
        Employee emp1 = new Employee(){EmpId=101,EmpName = "Selva",Salaray=40000};
        Employee emp2 = new Employee(){EmpId=102,EmpName = "Dinesh",Salaray=50000};
        Employee emp3 = new Employee(){EmpId=103,EmpName = "Roganth",Salaray=60000};
        Employee emp4 = new Employee(){EmpId=104,EmpName = "Sujith",Salaray=70000};
        Employee emp5 = new Employee(){EmpId=105,EmpName = "Susi",Salaray=80000};
        List<Employee> emps1 = new List<Employee>{emp1,emp2,emp3,emp4,emp5};

        // Using Lambda Expression
        // var emps2 = emps1.Where(emp1 => emp1.Salaray>40000);
        
        //LINQ (Language Integrated Query)
        var emps2 = from emp in emps1 where emp.Salaray>40000 select emp;
        
        Console.WriteLine("Getting Employee details above 40000k..");
        foreach (Employee emp in emps2)
        {
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.EmpName);
            Console.WriteLine(emp.Salaray);
        }


        //Names of emps getting above 40k
        // var emps3 = emps1.Where(emp1 => emp1.Salaray>40000).Select(emp1 => emp1.EmpName);
        var emps3 = from emp in emps1 where emp.Salaray>40000 select emp.EmpName;

        System.Console.WriteLine("Getting Employee Names above 40000k With Names..");
        foreach (var name in emps3)
        {
            Console.WriteLine(name);
        }



        //ids and names of ems getting above 40k
        // var emps4 = emps1.Where(emp1 => emp1.Salaray>40000).Select(emps1 => new {emp1.EmpId, emp.EmpName});
        var emps4 =  from emp in emps1 where emp.Salaray>40000 select new { emp.EmpId, emp.EmpName };
        Console.WriteLine("Ids and names of emps getting above 40k");
        foreach(var x in emps4)
        {
            Console.WriteLine($"ID: {x.EmpId}, Name: {x.EmpName}");
        }



        //Names and salaries of all emps
        //var emps5 = emps1.Select(emp1=> new {emps1.EmpName,emps1.Salary});
        var emps5 = from emp in emps1 select new { emp.EmpName, emp.Salaray };
        Console.WriteLine("Names and Salaries of all employees");
        foreach(var x in emp5)
        {
            Console.WriteLine($"Name: {x.EmpName}, Salary: {x.Salaray}");
        }



        Console.Write("Enter Emp Id: ");
        int eid = Convert.ToInt32(Console.ReadLine());
        try
        {
            //var emps6 = emps1.Single(emp1 => emp1.EmpId == eid);
            var emps6 = (from emp in emps1 where emp.EmpId == eid select emp).First();
            Console.WriteLine($"Name: {emp1.EmpName}, Salary: {emp1.Salaray}");
        }
        catch
        {
            Console.WriteLine("No such emp id");
        }
       



        //var emps7 = emps1.OrderBy(emps1 => emps1.EmpName);
        var emps6 = from emp in emps1 orderby emp.EmpName select emp;
        System.Console.WriteLine("Emp details in alphabetical order of name");
        foreach (Employee emp1 in emps7)
            System.Console.WriteLine($"Emp Id: {emp1.EmpId}, Name: {emp1.EmpName}, Salary: {emp1.Salary}");

        System.Console.WriteLine("--------------------------------------");

        //var emps8 = emps1.OrderByDescending(emps1 => emps1.Salary);
        var emps8= from emp in emps1 orderby emp.Salaray descending select emp;
        foreach (Employee emp1 in emps8)
            System.Console.WriteLine($"Emp Id: {emp1.EmpId}, Name: {emp1.EmpName}, Salary: {emp1.Salary}");




          // First 3 records
        var emps9 = emps.Take(3);
        System.Console.WriteLine("First 3 employees...");
        foreach (Employee emp in emps9)
            System.Console.WriteLine($"Emp Id: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.Salary}, Dept: {emp.Department}");
 
        // Last 3 records
        var emps10 = emps.Skip(2);
        System.Console.WriteLine("3rd to last...");
        foreach (Employee emp in emps10)
            System.Console.WriteLine($"Emp Id: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.Salary}, Dept: {emp.Department}");
 
       
        // 3rd and 4th records
        var emps11 = emps.Skip(2).Take(2);
        System.Console.WriteLine("3rd and 4th emps...");
        foreach (Employee emp in emps11)
            System.Console.WriteLine($"Emp Id: {emp.EmpId}, Name: {emp.EmpName}, Salary: {emp.Salary}, Dept: {emp.Department}");
 
        // Employee with the highest salary
        var empL2 = emps.OrderByDescending(e => e.Salary).First();
        System.Console.WriteLine("Emp with the highest salary...");
        System.Console.WriteLine($"Emp Id: {empL2.EmpId}, Name: {empL2.EmpName}, Salary: {empL2.Salary}, Dept: {empL2.Department}");
 
        // Employee with the least salary
        var empL3 = emps.OrderByDescending(e => e.Salary).Last();
        System.Console.WriteLine("Emp with the least salary...");
        System.Console.WriteLine($"Emp Id: {empL3.EmpId}, Name: {empL3.EmpName}, Salary: {empL3.Salary}, Dept: {empL3.Department}");
    }
}
 