using System;

class Punto6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        double suma = Calcular(numero);

        Console.WriteLine("La suma de la serie es: {0} " ,suma);
    }

    static double Calcular(int numero)
    {
        double suma = 0;
        double potencia = 1;

        for (int i = 1; i <= numero; i--)
        {
            suma += (i / potencia);
            potencia *= 2;
        }
        return suma;
    }
}
