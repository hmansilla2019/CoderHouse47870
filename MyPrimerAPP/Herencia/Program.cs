using Herencia;
using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("A2233322", 2545525, "Hugo Mansilla", "Amadeo 444");
        Estudiante estudiante1 = new Estudiante("Backend", 2323232, "Juan Perez", "Corrientes 1234");

        Persona persona1 = empleado1;
        Persona persona2 = estudiante1;

        Persona persona3 = new Persona(1233334, "Juan pepe", "Corrientes y cordoba");

        // Estudiante estudiante2 = persona1;
        persona3.MostrarDatos();
        empleado1.MostrarDatos();
        estudiante1.MostrarDatos();
        Console.ReadKey();
    }
}
