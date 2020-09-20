using Agendamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Repositorio
{
    public interface IClienteRepository
    {

        void Cadastrar(Cliente cliente);
        void ExcluirCliente(string cpf);
        void AlterarCliente(Cliente cliente);
        IList<Cliente> ConsultarCliente();
        Cliente ConsultarClientePorParametro(string cpf);


    }
}
