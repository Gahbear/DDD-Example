using Domain.Commands;

namespace Domain.Interfaces
{
    public interface IClientesRepository
    {
        Task<string> PostAsync(ClienteCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<ClienteCommand>>GetClienteCommandsAsync();
    }
}
