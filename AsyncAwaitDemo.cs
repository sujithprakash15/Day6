using System.Threading.Tasks;

class Program
{
static async Task PrintNumberAsync()
    {
        Console.WriteLine("DisplayNumber Started");
        for(int i = 1; i <= 500; i++)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine("DisplayNumbers Stopped");
    }

    static async Task<string> GetDataAsync()
    {
        //Getting the data from a database
        System.Threading.Thread.Sleep(2000);
        string str = "Result";
        return str;
    }


    static async Task Main()
    {
        Console.WriteLine("Main Started");
        Task.Run(PrintNumberAsync);

        string data = await GetDataAsync();
        Console.WriteLine(data);
        

        Console.WriteLine("Main Stopped");
        Console.ReadLine();
    }
}