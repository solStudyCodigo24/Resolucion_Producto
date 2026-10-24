public class Matematica
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        Matematica operacion = new Matematica();
        Console.WriteLine($"Sumar enteros: {operacion.Sumar(5, 6)}");
        Console.WriteLine($"Sumar decimales: {operacion.Sumar(5.1, 6.1)}");
    }
}