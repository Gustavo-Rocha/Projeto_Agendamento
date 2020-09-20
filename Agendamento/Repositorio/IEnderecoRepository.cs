using Agendamento.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System;

namespace Agendamento.Repositorio
{
    public interface IEnderecoRepository
    {

        Task<HttpResponseMessage> Cadastrar(Endereco endereco);
        Task<HttpResponseMessage> ExcluirEndereco(string cep);
        Task AlterarEndereco(Endereco endereco);
        Task<List<Endereco>> ConsultarEndereco();
        Task<Boolean> ConsultarComParametro(string cep);

    }
}