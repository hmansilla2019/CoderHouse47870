using AppClientesData;
using AppClientesEntities;
namespace AppClientesBussiness
{
    public static class ClienteBussiness
    {
        public static List<Cliente> GetClientes()
        {
            return ClienteData.GetClientes();
        }
    }
}