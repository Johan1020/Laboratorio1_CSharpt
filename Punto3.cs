namespace consola;

class Program
{
    static void Main(string[] args)
    {
        double radio;
        double angulo;
        double radioRadian;
        double anguloRadian;
        double x;
        double y;



        Console.WriteLine($"Ingresa la coordenada polar (radio)");
        radio = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingresa la coordenada polar (angulo)");
        angulo = double.Parse(Console.ReadLine());

        anguloRadian = angulo * (Math.PI / 180.0);
        y = CalcularY(radio, anguloRadian);
        x = CalcularX(radio, anguloRadian);


        Console.WriteLine($"La coordenada rectangular (y) es: {y}");
        Console.WriteLine($"La coordenada rectangular (x) es: {x}");
    }

    static double CalcularY(double radio, double angulo)
    {
        return radio * Math.Sin(angulo);
    }
    static double CalcularX(double radio, double angulo)
    {
        return radio * Math.Cos(angulo);
    }
}
