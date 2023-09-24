using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGestionAfter
{
    public static class  Contexto
    {
    #region Productos
    public static List<Producto> ListarProductos()
    {
        List<Producto> lista = new List<Producto>();
        // Importante: Para que funcione
        // Modifica el parametro Server por el de tu Servidor
        string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";

        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                lista.Add(producto);
                            }
                        }
                    }
                }

                // Opcional
                conexion.Close();
            }
            return lista;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public static Producto ObtenerProducto(int id)
    {
        Producto producto = new Producto();
        // Importante: Para que funcione
        // Modifica el parametro Server por el de tu Servidor
        string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto Where Id=@Id";

        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });


                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                producto.Id = Convert.ToInt32(dr["Id"]);
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            }
                        }
                    }
                }

                // Opcional
                conexion.Close();
            }
            return producto;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public static void CrearProducto(Producto producto)
    {
        string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        string query = "INSERT INTO Producto (Descripciones,Costo, PrecioVenta,Stock, IdUsuario)" +
            " VALUES(@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario); ";

        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // se puede determinar si es Procedimiento Tabla o consulta
                    // comando.CommandType = CommandType.TableDirect;

                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
        catch (Exception ex)
        {

            throw;
        }


    }

    public static void ModificarProducto(Producto producto)
    {
        string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        string query = "UPDATE Producto " +
            "SET Descripciones = @Descripcion ,Costo = @Costo, PrecioVenta = @PrecioVenta,Stock = @Stock, IdUsuario=@IdUsuario " +
            " WHERE Id = @Id";
        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
        catch (Exception ex)
        {

            throw;
        }
    }

    public static void EliminarProducto(Producto producto)
    {
        string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        string query = "DELETE FROM Producto " +
            " WHERE Id = @Id";
        try
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }

        }
        catch (Exception ex)
        {

            throw;
        }
    }
    #endregion

    #region Usuario
    #endregion

    #region Venta
    #endregion

    #region ProductoVendido
    #endregion


    }

}
