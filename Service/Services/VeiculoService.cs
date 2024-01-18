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

            if (command.TipoVeiculo != ETipoVeiculo.SUV
                && command.TipoVeiculo != ETipoVeiculo.Picape
                && command.TipoVeiculo != ETipoVeiculo.Elétrico
                )
                return "O tipo de Veículo é menor que o permitido";

            return await _repository.PostAsync(command);
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugadosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SimularVeiculoAluguelViewModel> SImularVeiculoAluguel()
        {
            throw new NotImplementedException();
        }

        public async Task<SimularVeiculoAluguelViewModel> SImularVeiculoAluguel(int totalDiasSimulados, ETipoVeiculo tipoVeiculo)
        {
            var veiculoPreco = await _repository.GetPrecoDiaria(tipoVeiculo);
            double taxaEstadual = 10.50;
            double taxaFederal = 3.5;
            double taxaMunicipal = 13.5;

            var simulacao = new SimularVeiculoAluguelViewModel();
            simulacao.TotalDiasSimulado = totalDiasSimulados;
            simulacao.Taxas = (decimal) (taxaMunicipal + taxaEstadual + taxaFederal);
            simulacao.TipoVeiculo = tipoVeiculo;
            simulacao.ValorDiaria = veiculoPreco.Preco;
            simulacao.ValorTotal = (totalDiasSimulados * veiculoPreco.Preco) + simulacao.Taxas;

            if (totalDiasSimulados > veiculoPreco.PeriodoMaximoAluguel)
                return null;

            return simulacao;
        }
    }
}
