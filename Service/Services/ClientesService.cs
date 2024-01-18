using Domain.Commands;
using Domain.Interfaces;

namespace Service.Services
{
    public class ClientesService
    {
        private readonly IClientesRepository _repository;
        public ClientesService(IClientesRepository repository)
        {
            _repository = repository; 
        }
        public void GetAsync() 
        {
            throw new NotImplementedException();
        }
        public async Task<string> PostAsync(ClienteCommand command)
        {
            int AnoAtual = DateTime.Now.Year;

            if (command == null)
                return "Todos os Campos são Obrigatórios";

            //se for menor não pode cadastrar
            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.DataNascimento.Year < 18)
                return "O ano do veículo é menor que o permitido";

            return await _repository.PostAsync(command);
        }
    }
}
