using Dapper;
using Domain.Commands;
using Domain.Enums;
using Domain.Interfaces;
using System.Data.SqlClient;
namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(VeiculoCommand command)
        {
            string queryInsert = @"INSERT INTO (Veiculo Placa,AnoFabricacao,TipoVeiculoId,Estado,MontadoraId,VeiculoAlugado)
                                 VALUES (@Placa, @AnoFabricacao,@TipoVeiculoId, @Estado, @MontadoraId, @VeiculoAlugado)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    placa = command,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoId = (int) command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = (int) command.Montadora,
                });

                return "Veiculo cadastrado com sucesso";
            }

        }

        public void PostAsync()
        {

        }

        public void Getsync()
        {

        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugadosAsync()
        {
            string queryget = @"Select * from Veiculo";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<VeiculoCommand>(queryget);
            }
        }

            
       
    }

    

}
