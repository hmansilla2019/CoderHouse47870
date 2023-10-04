
using AppClientesEntities;
using System.Data.SqlClient;

namespace AppClientesData
{
    public static class ClienteData
    {
        private static string connectionString = @"Server=LAPTOP-D0DVPQB2\SQLHUGO;DataBase=SistemaGestion;
                                        Trusted_Connection=True";

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
    }
}