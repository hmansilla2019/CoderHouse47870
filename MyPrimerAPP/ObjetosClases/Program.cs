using ObjetosClases;

// Crea instancia de la clase Producto invocando constructor sin parametros, que en este caso seteara los atributos por default
Producto testProducto = new Producto();

// Crea instancia de la clase Producto invonando constructor con parametros que en este caso seteara atributos con los valores
// Pasados por parametros
Producto testProductoParametrizado = new Producto(1,"Camisa",50000,100000,"Ropa");


// Invoca metodo que evalua si hay precio de venta
if (!testProducto.HayPrecioDeVenta())
{
    Console.WriteLine("No hay precio de venta");
}
else
{
    Console.WriteLine("No hay precio de venta");
}


// Uso de Set, se hace a trabes de un setter de una property que se encarga en este caso de modificar internamente el atributo _PrecioVenta
testProductoParametrizado.PrecioVenta = 500;

// Invoca metodo que evalua si hay precio de venta
if (!testProductoParametrizado.HayPrecioDeVenta())
{
    Console.WriteLine("No hay precio de venta");
}
else
{
    Console.WriteLine("No hay precio de venta");
}

// USo de Get, se hace a traves de un getter de una property que se encarga de obtener (get) el valor del atributo en este caso _PrecioVenta
Console.WriteLine(testProductoParametrizado.PrecioVenta);






Console.WriteLine();