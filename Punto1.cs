namespace consola;
class Program
{
    static void Main(string[] args)
    {
        int anio = 0;
        Console.WriteLine($"Ingrese su año de nacimiento");
        anio=int.Parse(Console.ReadLine());
        Console.WriteLine($"su edad es: {CalcularEdad(anio)}");
    }


    static int CalcularEdad(int anio){
        int edad= 2024-anio;
        return edad;
    }


}
