using Domain.Commands;
using Domain.Enum;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        //A interface é um contrato, apenas usamos para adicionar metodos,não é feita a implementação de nada

        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();

        Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugadosAsync();
        Task<SimularVeiculoAluguelViewModel> SImularVeiculoAluguel(int TotalDiasSimulados, ETipoVeiculo tipoVeiculo);
    }
}
