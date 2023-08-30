// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string myCadena = "Bienvenido Hugo";
string cadenaVacia = string.Empty;
string cadenaNula = null;
string cadenaNombre = "Hugo";
int edad = 40;
bool estado = true;


if (cadenaNula == cadenaVacia)
{
    Console.WriteLine("Error");
}

Console.WriteLine(myCadena.Length);
Console.WriteLine(cadenaVacia.Length);
Console.WriteLine(myCadena.ToLower());
Console.WriteLine(myCadena.ToUpper());

if (myCadena.Contains(cadenaNombre))
{
    Console.WriteLine(myCadena);
}

if (cadenaNombre.Equals("Juan"))
{
    Console.WriteLine("Bienvenido Juan");
}
else
{
    Console.WriteLine(myCadena);
}

Console.WriteLine(edad.ToString() + estado.ToString());

Console.ReadKey();


