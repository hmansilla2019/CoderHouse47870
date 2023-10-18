using AppClientesData;
using AppClientesEntities;

namespace AppClientesBussiness
{
    public static class ClienteBussiness
    {
        public static void AltaCliente(Cliente cliente)
        {
            ClienteData.AltaCliente(cliente);
        }

        public static void ModificarCliente(Cliente cliente)
        {
            ClienteData.ModificarCliente(cliente);
        }
        public static void EliminarCliente(int Id)
        {
            ClienteData.EliminarCliente(Id);
        }
        public static List<Cliente> GetClientes()
        {
            return ClienteData.GetClientes();
        }
    }
}