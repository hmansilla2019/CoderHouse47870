// See https://aka.ms/new-console-template for more information

string sNombre=string.Empty;
const double pi = 3.14159;
double area_circulo;
int radiocirculo = 1;
string resultado = "El area del circulo es ";

Console.WriteLine("Bienvenidos");

Console.WriteLine("Indique su nombre:");

sNombre = Console.ReadLine();

Console.WriteLine("Bienvenido " + sNombre);

Console.WriteLine("Ingrese el Radio del Circulo");

radiocirculo = Convert.ToInt32(Console.ReadLine());

area_circulo = pi * (radiocirculo * radiocirculo);

Console.WriteLine(resultado + area_circulo);

Console.ReadKey();
