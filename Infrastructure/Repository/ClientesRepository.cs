using Domain.Commands;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClienteCommand>> GetClienteCommandsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsync(ClienteCommand command)
        {
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
