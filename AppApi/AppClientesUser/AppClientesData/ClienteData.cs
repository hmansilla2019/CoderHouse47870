
using AppClientesEntities;
using System.Data;
using System.Data.SqlClient;

namespace AppClientesData
{
    public static class ClienteData
    {
        private static string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

      
        public static void AltaCliente(Cliente cliente)
        {
            string query = "INSERT INTO Clientes (NombreApellido,Telefono, Domicilio)" +
                           " VALUES(@NombreApellido, @Telefono, @Domicilio); ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = cliente.NombreApellido });
                        comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = cliente.Telefono });
                        comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = cliente.Domicilio });
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

        public static List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query = "SELECT Id,NombreApellido,Domicilio,Telefono FROM Clientes";

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
                                    var cliente = new Cliente();
                                    cliente.Id = Convert.ToInt32(dr["Id"]);
                                    cliente.NombreApellido = dr["NombreApellido"].ToString();
                                    cliente.Domicilio = dr["Domicilio"].ToString();
                                    cliente.Telefono = dr["Telefono"].ToString();

                                    clientes.Add(cliente);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                return clientes;
            }
        }


        public static void ModificarCliente(Cliente cliente)
        {
            string query = "UPDATE Clientes" +
                           " SET NombreApellido=@NombreApellido,Telefono=@Telefono, Domicilio=@Domicilio" +
                           " WHERE id=@Id;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = cliente.Id });
                        comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = cliente.NombreApellido });
                        comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = cliente.Telefono });
                        comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = cliente.Domicilio });
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

        public static void EliminarCliente(int Id)
        {
            string query = "DELETE FROM Clientes " +
                           " WHERE Id = @Id; ";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
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


    }
}