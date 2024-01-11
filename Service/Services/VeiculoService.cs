using Domain.Commands;
using Domain.Enum;
using Domain.Interfaces;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        //Injeção de dependência

        private readonly IVeiculoRepository _repository;

        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {

            int AnoAtual = DateTime.Now.Year;

            if (command == null) 
                    return "Todos os Campos são Obrigatórios";

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)
                return "O ano do veículo é menor que o permitido";

            if (command.TipoVeiculo != ETipoVeiculo.SUVs
                && command.TipoVeiculo != ETipoVeiculo.Picapes
                && command.TipoVeiculo != ETipoVeiculo.Elétricos
                )
                return "O tipo de Veículo é menor que o permitido";

            return await _repository.PostAsync(command);
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
