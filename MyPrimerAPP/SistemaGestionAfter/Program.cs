// See https://aka.ms/new-console-template for more information
using SistemaGestionAfter;

Console.WriteLine("Hello, World!");

Console.WriteLine("Lista de Productos");

List<Producto> lista = Contexto.ListarProductos();
foreach (var item in lista)
{
    Console.WriteLine("Descripcion " + item.Descripciones);

}

Producto producto = new Producto();
// Le pido al usuario los datos
producto.PrecioVenta = 5000;
producto.Costo = 2000;
producto.Descripciones = "Algo";
producto.Stock = 100;
producto.IdUsuario = 1;
Contexto.CrearProducto(producto);


