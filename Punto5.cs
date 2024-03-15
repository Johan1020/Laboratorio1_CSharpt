namespace consola;
class Program
{
    static int limite = 10;
    static int suma = 0;
    static int ultimo = 0;
    static int penultimo = 1;
    static void Main(string[] args)
    {
        ImprimirSecuencia(0);
    }

    static void ImprimirSecuencia(int i)
    {
        if (i < limite-1)
        {
            if (i == 0)
            {
                Console.WriteLine(ultimo);
                Console.WriteLine(penultimo);
            }
            else
            {
                suma = ultimo + penultimo;
                ultimo = penultimo;
                penultimo = suma;
                Console.WriteLine(suma);
            }

            ImprimirSecuencia(i + 1);
        }
    }
}
