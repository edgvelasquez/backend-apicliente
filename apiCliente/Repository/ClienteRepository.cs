using apiCliente.Configuration;
using apiCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace apiCliente.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DBContextConfiguration _context;
        public async Task<List<Cliente>> getClientesLinq()
        {
            return await _context.Cliente.FromSqlRaw("EXEC getClientes").ToListAsync();
        }

        public async Task<List<Cliente>> getClientesSP()
        {
            return await _context.Cliente.OrderBy(c => c.id).ToListAsync();
        }
    }
}
