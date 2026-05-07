internal class Program
{
    private static void Main(string[] args)
    {
        int ocupados = 0;
        int disponibles;

        do
        {
            disponibles = 200 - ocupados;
            Console.WriteLine("Cajones disponibles: " + disponibles);

            ocupados++;
        } while (ocupados < 200);

        Console.WriteLine("Ya no hay cajones disponibles");
    }
}