// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography;

float num1 = 0.0f, num2= 0.0f, suma = 0.0f, resta = 0.0f, multiplicacion = 0.0f;
float division = 0.0f;

Console.WriteLine("Ingresar Primer Numero");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingresar Segundo Numero");
num2 = float.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
multiplicacion = num1 * num2;
division = num1 / num2;


Console.WriteLine("La suma es " + suma);
Console.WriteLine("La resta es " + resta);
Console.WriteLine("La multiplicacion es " + multiplicacion);
Console.WriteLine("La division es " + division);

if (multiplicacion >= 20)
{
    multiplicacion -= resta;
    Console.WriteLine("Se resto la resta a la multiplicacion");
}
else
{
    multiplicacion += suma;

    Console.WriteLine("Se sumo la suma a la multiplicacion");
}



Console.WriteLine("La multiplicacion es " + multiplicacion);

Console.ReadLine();