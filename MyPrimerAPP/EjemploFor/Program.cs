// See https://aka.ms/new-console-template for more information


int i;
int cantidadNotasACargar = 0;
double promedioNotas = 0;
double nota;
double sumaNotas=0;
int contadorAprobado = 0;
int contadorReprobado = 0;
bool aplazado = false;

Console.WriteLine("Ingrese cantidad de notas a cargar");
cantidadNotasACargar = int.Parse(Console.ReadLine());

for (i = 1; i <= cantidadNotasACargar; i++)
{
    Console.WriteLine("Ingrese la nota:");
    nota = double.Parse(Console.ReadLine());
    if (nota >=7)
    {
        contadorAprobado++;
    }
    else
    {
        if (nota<=2)
        {
            aplazado = true;
            break;
        }
        if (nota>2 && nota <4)
        {
            cantidadNotasACargar--;
            continue;
        }
        contadorReprobado++;

    }

    sumaNotas += nota;

}
if (aplazado)
{
    Console.WriteLine("Rinde Final");
}
promedioNotas = sumaNotas / cantidadNotasACargar;
Console.WriteLine($"El promedio de las notas: {promedioNotas}");
Console.WriteLine($"Aprobraron: {contadorAprobado}");
Console.WriteLine($"Reprobarom: {contadorReprobado}");
Console.ReadKey();
