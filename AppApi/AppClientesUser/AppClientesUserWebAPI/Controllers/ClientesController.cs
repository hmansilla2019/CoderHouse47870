using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppClientesBussiness;
using AppClientesEntities;
namespace AppClientesUserWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        [HttpGet(Name = "GetClientes")]
        public IEnumerable<Cliente> Get()
        {
            return ClienteBussiness.GetClientes().ToArray();
        }


        [HttpDelete(Name = "EliminarCliente")]
        public void Delete([FromBody] int Id)
        { 
            ClienteBussiness.EliminarCliente(Id);
        }

        [HttpPut(Name = "ModificarCliente")]
        public void Put([FromBody] Cliente cliente)
        {
            ClienteBussiness.ModificarCliente(cliente);
        }

        [HttpPost(Name = "AltaCliente")]
        public void Post([FromBody] Cliente cliente)
        {
            ClienteBussiness.AltaCliente(cliente);
        }


    }
}
