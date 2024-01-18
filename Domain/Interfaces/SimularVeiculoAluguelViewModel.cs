using Domain.Enum;

namespace Domain.Interfaces
{
    public class SimularVeiculoAluguelViewModel
    {
        public decimal ValorTotal { get; set; }
        public decimal ValorDiaria { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public decimal Taxas { get; set; }
        public int TotalDiasSimulado { get; set; }
    }
}