using Domain.Commands;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VeiculoService : IVeiculoSevice
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)
        {
            if (new command = null)

            //To-do
            //Incluir validação, só podem cadastrar veículos com até 5 anos de uso
            //To do
            //Incluir somente carros do tipo SUV, Sedan e Hatch
            
            if(command.TipoVeiculo != ETipoVeiculo.SUV
               || command.TipoVeiculo != ETipoVeiculo.Hetch
               || command.TipoVeiculo != ETipoVeiculo.Sedan
            )

            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
