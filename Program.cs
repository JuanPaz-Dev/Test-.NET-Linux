namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?");
            var nombre = Console.ReadLine();
            var fechaActual = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hola, {nombre}, la fecha actual es {fechaActual:d} y son las {fechaActual:t}!");
            Console.Write($"{Environment.NewLine}Presione una tecla para finalizar...");
            Console.ReadKey(true);
        }
    }
}
