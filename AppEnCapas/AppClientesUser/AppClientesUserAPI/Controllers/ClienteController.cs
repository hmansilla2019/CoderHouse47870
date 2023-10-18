using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppClientesEntities;
using AppClientesBussiness;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet(Name = "GetClientes")]
        public IEnumerable<Cliente> Get()
        {
            return ClienteBussiness.GetClientes()
            .ToArray();
        }

        [HttpPost(Name = "AltaCliente")]
        public void Post([FromBody] Cliente cliente)
        {
            ClienteBussiness.AltaCliente(cliente);
        }

        [HttpPut(Name = "ModificarCliente")]
        public void Put([FromBody] Cliente cliente)
        {
            ClienteBussiness.ModificarCliente(cliente);
        }

        [HttpDelete(Name = "EliminarCliente")]
        public void Delete([FromBody] int Id)
        {
            ClienteBussiness.EliminarCliente(Id);
        }
    }
}
