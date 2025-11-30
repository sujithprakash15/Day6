using System.Threading;
class Program
{
    static void DisplayNumbers()
    {
        System.Console.WriteLine("DisplayNumbers started");
        for(int i=1;i<=500;i++)
            System.Console.WriteLine(i);
        System.Console.WriteLine("DisplayNumbers stopped");
    }
    static void Main()
    {
        //Synchronous call
        System.Console.WriteLine("Main started");
        //DisplayNumbers();
       
        //Asynchronous call using thread
 
        ThreadStart threadStart = new ThreadStart(DisplayNumbers);
        Thread thread = new Thread(threadStart);
        thread.Start();
        System.Console.WriteLine("Main stopped");
        Console.ReadLine();
    }
}