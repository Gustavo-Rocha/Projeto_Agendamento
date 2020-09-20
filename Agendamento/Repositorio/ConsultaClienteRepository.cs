using Agendamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Repositorio
{
    public class ConsultaClienteRepository : IConsultaCliente
    {
        private readonly ApplicationContext context;
        public ConsultaClienteRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IList<Cliente> Consultar()
        {

            return  context.Clientes.ToList();

        }
    }
}
