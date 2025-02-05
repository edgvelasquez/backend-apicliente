using apiCliente.Models;

namespace apiCliente.Repository
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> getClientesSP();
        Task<List<Cliente>> getClientesLinq();
    }
}
