// See https://aka.ms/new-console-template for more information


#region App Principal

int resultado;
int num1;
int num2;
int resta = 0;
int i;
num1 = 3;
num2 = 4;

{
    int num3 = 2;

}

// num3 fuera de alcance
// resta = num1 + num3;


if (num1>num2)
{
    int suma = num1 + num2;
}
// suma fuera de alcance
// Console.WriteLine(suma);

for (i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine(i++);
for (int j = 0; j < 4; j++)
{
    Console.WriteLine(j);
}

// j fuera de AMBITO o ALCANCE o SCOPE
// Console.WriteLine(j);

resta = 3 + 4;

Saludar();

IngresarDatos(out num1, out num2);


resultado = Suma(num1, num2);

Console.WriteLine("La suma es " + resultado);

Pausa();

#endregion



#region Funciones
void Saludar()
{
    Console.WriteLine("Bienvenidos a la clase de Funciones");
}

void Pausa()
{
    Console.ReadKey();
}

int Suma(int numero1, int numero2)
{
    numero1 = 4;
    int suma = numero1 + numero2;
    return suma;
}

void IngresarDatos(out int numero1,out int numero2)
{
    Console.WriteLine("Ingrese primer numero ");
    numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo numero ");
    numero2 = int.Parse(Console.ReadLine());
}

#endregion

