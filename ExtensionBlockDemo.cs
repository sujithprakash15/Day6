//extension blocks (C# 14 in dotnet 10)
 
class Sample
{
    public void Method1(){}
}

static class Xyz
{
    //public static void Method2(this Sample s) {}
    //public static void Method3(this sample s, int x){}
 
    extension(Sample s)
    {
        public void Method2(){} //extension methods
        public void Method3(int x){}
        public string Message => "Hello";
    }

    extension<T>(List<T>)
    {
        public static List<T> Empty = new List<T>(); //Static Extension Member
    }
}
 
class Program
{
    static void main()
    {
        Sample obj = new Sample();
        obj.Method1();
        obj.Method2();
        obj.Method3();
        obj.Message = "Hi";
        Console.WriteLine(obj.Message);
        //var emptyList = emptyList<int>.Empty;

        var emptyList = List<int>.Empty;
        var list2 =List<string>.Create();
    }
}
 