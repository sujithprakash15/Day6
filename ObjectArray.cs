class Employee
{
    public int EmpId { get; set; } //Automatic property
    public string EmpName { get; set; }     
    public decimal Salary { get; set; }         
}

class Program
{
    static void Main()
    {
        Employee[] emps = new Employee[5];
        for(int i = 0; i < 5; i++)
        {
            emps[i] = new Employee();
            Console.Write("Enter Emp Id: ");
            emps[i].EmpId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter name: ");
            emps[i].EmpName=Console.ReadLine();

            Console.Write("Enter Salary: ");
            emps[i].Salary = Convert.ToDecimal(Console.ReadLine());

        }
        // List<Employee> l1 = new List<Employee>();
        // Employee e1 = new Employee();
        // l1.Add(e1);
    }
}