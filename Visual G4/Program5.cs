internal class Program
{
    private static void Main(string[] args)
    {
        static void Main()
        {
            int num;

            Console.Write("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}