// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int contintentos = 1;
int maximoIntentos = 5;

string passOriginal = "Coder!2023";

Console.WriteLine("Ingrese la contraseña");
string password = Console.ReadLine();

while (password != passOriginal)
{
    if (contintentos> maximoIntentos)
    {
        Console.WriteLine("Supero la cantidad de intentos permitida");
        break;
    }
    Console.WriteLine("Su password es invalido. Por Favor ingrese nuevamente");
    password = Console.ReadLine();
    contintentos++;
}
Console.WriteLine("Bienvenido a Corder!!!");


Console.ReadKey();  
