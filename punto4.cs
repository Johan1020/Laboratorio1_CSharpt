using System;

class Punto4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero X: ");
        double x = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero n: ");
        int n = int.Parse(Console.ReadLine());

        double resultado = Calcular(x, n);

        Console.WriteLine("El resulta es: " + resultado);
    }

        static double Calcular(double x, int n)
        {
            double suma = 0;

            for (int i = 0; i <= n; i++)
            {
                suma += Math.Pow(x, i);
            }

        return suma;
        }
}

