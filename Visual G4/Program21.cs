internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + (num * i));
        }
    }
}