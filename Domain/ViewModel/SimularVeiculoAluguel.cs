using Domain.Enum;

namespace Domain.ViewModel
{
    public class SimularVeiculoAluguel
    {
        public decimal ValorTotal {  get; set; }
        public decimal ValorDiaria {  get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public decimal Taxas { get; set; }
        public int TotalDiasSimulado { get; set; }
    }
}
