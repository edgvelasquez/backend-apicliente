using apiCliente.Repository;
using Microsoft.AspNetCore.Mvc;

namespace apiCliente.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController:ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("getClientesSP")]
        public async Task<IActionResult> getClientesSP(int pagina = 1, int tamano = 10)
        {
            var clientes = await _clienteRepository.getClientesSP();
            return Ok(clientes);
        }

        [HttpGet("getClientesLinq")]
        public async Task<IActionResult> getClientesLinq(int pagina = 1, int tamano = 10)
        {
            var clientes = await _clienteRepository.getClientesLinq();
            return Ok(clientes);
        }
    }
}
