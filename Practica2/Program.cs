namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variable
            string nombre;
            string apellido;
            int edad=15;



            Console.WriteLine("Introduce tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine(nombre + " " + apellido + " " + (1 + edad));
            Console.WriteLine((1 + 3) * 5m / 2);
        }
    }
}
