partial class ReportPrinter
{
    partial void PrintHeader();
    partial void PrintFooter();
    public void PrintReport()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }
}

partial class ReportPrinter
{
    private void PrintBody()
    {
        Console.Write("This is the report body");
    }
}

partial class ReportPrinter
{
    private void PrintHeader()
    {
        Console.Write("This is the report header");
    }
}

class Program
{
    static void Main()
    {
        ReportPrinter report = new ReportPrinter();
        report.PrintReport();
    }
}