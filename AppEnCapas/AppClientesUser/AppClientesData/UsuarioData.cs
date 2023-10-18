using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppClientesEntities;
namespace AppClientesData
{
    public class UsuarioData
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

        public static List<Usuario> Getusuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "SELECT Id ,Nombre,Apellido ,NombreUsuario,Contraseña,Mail FROM Usuario";

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
                                    var usuario = new Usuario();
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = dr["Contraseña"].ToString();

                                    usuarios.Add(usuario);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                return usuarios;
            }
        }


        public static void ModificarUsuario(Usuario usuario)
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
