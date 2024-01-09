using Domain.Commands;
using Domain.Enum;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
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

            return _veiculoRepository.PostAsync(command);
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
