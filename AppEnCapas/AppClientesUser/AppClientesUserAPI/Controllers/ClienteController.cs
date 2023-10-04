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
    }
}
