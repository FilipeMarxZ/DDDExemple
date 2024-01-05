using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoSevice
    {
        //Interface é um contrato, usamos apenas para adicionar metodos Não é feita implementação de nada.

        Task PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();

    }
}
