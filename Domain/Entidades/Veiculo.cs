using Domain.Enum;

namespace Domain.Entidades
{
    public class Veiculo
    {

        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public ETipoVeiculo TipoVeiculo { get; set; }
        public string Estado {  get; set; }
        public EMontadora Montadora { get; set; }
        public bool Alugado { get; set; } = false;
    }
}
