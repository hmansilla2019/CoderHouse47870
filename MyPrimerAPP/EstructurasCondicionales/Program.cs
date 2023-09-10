// See https://aka.ms/new-console-template for more information

/*
int cantidadProductosVendidos;
int cantidadProductosDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos");

cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadProductosDeposito - cantidadProductosVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos");
   //  cantidadProductosDeposito = cantidadProductosDeposito + 10;
   // Operador binario y unario 
    cantidadProductosDeposito += 10;
    Console.WriteLine("Productos cargados en el deposito");
}
else
{
    if (stock<=5)
    {
        Console.WriteLine("Stock minimo, reponer stock del producto.");
        cantidadProductosDeposito += 5;
        Console.WriteLine("Productos cargados en el deposito");
   //     Console.WriteLine($"Informar a ventas {stock} productos sin venter.");
    }
  //  else 
  //  {
  //      Console.WriteLine($"Informar a ventas {stock} productos sin venter.");
  //  }
    Console.WriteLine($"Informar a ventas {stock} productos sin venter.");



    //  Console.WriteLine("Informar a ventas {0} productos sin venter.",stock);
}

Console.ReadKey();
*/

// Universidad
string comision = string.Empty;

int nota = 0;
Console.WriteLine("Ingrese la comision");
comision = Console.ReadLine();

switch (comision)
{
    case "A":
        Console.WriteLine("Turno Mañana.");
        break;
    case "B":
        Console.WriteLine("Turno Tarde.");
        break;
    case "C":
        Console.WriteLine("Turno Noche.");
        break;

    default:
        Console.WriteLine("Sin turno asignados.");
        break;
}


Console.WriteLine("Ingrese la Nota");
nota = int.Parse(Console.ReadLine());




if (nota < 4)
{
    Console.WriteLine("Reprobo");
}
else
{
    if (nota<=7)
    {
        Console.WriteLine("Aprobo la cursada");
    }
    else
    {
        Console.WriteLine("Promociono");
    }
}

Console.ReadKey();







