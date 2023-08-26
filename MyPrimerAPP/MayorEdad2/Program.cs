// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

short edad = 0;
bool esEntero;


Console.WriteLine("Ingrese la Edad");

esEntero = short.TryParse(Console.ReadLine(), out edad);

if (esEntero && edad >= 18)
{
    Console.WriteLine("Es Mayor de edad");
}


Console.ReadKey();
