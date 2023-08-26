// See https://aka.ms/new-console-template for more information

int num1=0, num2=0, num3 = 0;
int menor = 0;

Console.WriteLine("Ingrese primer Numero");
num1 = Convert.ToInt32(Console.ReadLine());

menor = num1;

Console.WriteLine("Ingrese segundo Numero");
num2 = Convert.ToInt32(Console.ReadLine());

if (num2<menor)
{
    menor = num2;
}

Console.WriteLine("Ingrese tercer Numero");
num3 = Convert.ToInt32(Console.ReadLine());

if (num3 < menor)
{
    menor = num3;
}

Console.WriteLine("El menor es " + menor);

Console.ReadKey();

