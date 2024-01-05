using Domain.Commands;
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

        public Task PostAsync(VeiculoCommand command)
        {
            //To do

            //Incluir validação, só podem cadastrar veículos com até 5 anos de uso

            //To do

            //Incluir somente carros do tipo SUV, Sedans e Hatch
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
