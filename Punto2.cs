using System;

class Punto2
{
    static void Main()
    {

        String opc;
        do
        {
            MostrarMenu();
            opc = Console.ReadLine();

            switch (opc)
            {
                case "a":
                    Dividir();
                    break;
                case "b":
                    Cubo();
                    break;
                case "c":
                    IMC();
                    break;
            }

        } while (opc != "d");

     static void MostrarMenu()
        {
            Console.WriteLine("""
                ************************
                Menu: 
                a. Dividir
                b. Obtener cubo
                c. Calculo de IMC (Indice de masa corporal)
                d. Salir
                ************************
                """);
        }

        static void Dividir()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero numero: ");
            double num2 = double.Parse(Console.ReadLine());

            double dividir = num1 / num2;

            Console.WriteLine("El resultado de la divición es: " +dividir);
        }

        static void Cubo()
        {
            Console.Write("Ingrese un número para obtener su cubo: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cubo de " + numero + " es: " + cubo);
        }

        static void IMC()
        {
            Console.WriteLine("Ingrese su peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            double IMC = peso / (estatura * estatura);

            Console.WriteLine("La masa corporal es de: " + IMC);
        }
    }
}
