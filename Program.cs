internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Программа вычитания");
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        System.Console.WriteLine(a - b);
    }
}