using Dapper;
using Domain.Entidades;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = "";
        public async Task<string> PostAsync(Veiculo command)
        {
            string queryInsert = @"INSERT INTO (Veiculo Placa,AnoFabricacao,TipoVeiculoId,Estado,MontadoraId)
                                 VALUES (@Placa, @AnoFabricacao,@TipoVeiculoId, @Estado, @MontadoraId)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    placa = command,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculo = command.TipoVeiculo,
                    Estado = command.Estado,
                    Montadora = command.Montadora,
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
    }

    

}
