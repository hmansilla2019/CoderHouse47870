// See https://aka.ms/new-console-template for more information

int resultado = 0;

ObtenerMenor(out resultado);

Console.WriteLine("El menor es " + resultado);

void ObtenerMenor(out int menor)
{

    int num1 = 0, num2 = 0, num3 = 0;

    Console.WriteLine("Ingrese primer Numero");
    num1 = Convert.ToInt32(Console.ReadLine());

    menor = num1;

    Console.WriteLine("Ingrese segundo Numero");
    num2 = Convert.ToInt32(Console.ReadLine());


    if (num2 < menor)
    {
        menor = num2;
    }

    Console.WriteLine("Ingrese tercer Numero");
    num3 = Convert.ToInt32(Console.ReadLine());

    if (num3 < menor)
    {
        menor = num3;
    }
}

Console.ReadKey();

