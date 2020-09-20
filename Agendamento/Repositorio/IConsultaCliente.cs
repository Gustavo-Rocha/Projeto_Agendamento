using Agendamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Repositorio
{
    public interface IConsultaCliente
    {

        IList<Cliente> Consultar();
    }
}
