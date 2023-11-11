// See https://aka.ms/new-console-template for more information


using EjercicioManejoDeExpreciones;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int b = Convert.ToInt32(Console.ReadLine());

            Operaciones op = new Operaciones();

            Console.WriteLine("Suma: " + op.Sumar(a, b));
            Console.WriteLine("Resta: " + op.Restar(a, b));
            Console.WriteLine("Multiplicación: " + op.Multiplicar(a, b));
            Console.WriteLine("División: " + op.Dividir(a, b));
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor, ingrese solo números.");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
