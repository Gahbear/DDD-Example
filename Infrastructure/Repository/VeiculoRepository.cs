using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(VeiculoCommand command)
        {
            string queryInsert = @"
INSERT INTO Veiculo(Placa, AnoFabricacao, TipoVeiculoId, Estado, MontadoraId)
VALUES(@Placa, @AnoFabricacao, @TipoVeiculoId, @Estado, @MontadoraId)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoId = command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = command.Montadora
                });

                return "Veiculo Cadastrado com sucesso";
            }

        }
        public void PostAsync()
        {

        }
        public void GetAsync()
        {

        }
    }
}
