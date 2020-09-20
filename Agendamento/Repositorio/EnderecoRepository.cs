using Agendamento.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento.Repositorio
{
    public class EnderecoRepository : IEnderecoRepository
    {
         private readonly HttpClient httpClient = new HttpClient();

        public Task AlterarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> Cadastrar(Endereco endereco)
        {
            httpClient.BaseAddress = new System.Uri("https://localhost:44379/api/");


            
            HttpResponseMessage post = await httpClient.PostAsync("Enderecos", new StringContent(
                        JsonConvert.SerializeObject(endereco), Encoding.UTF8, "application/json"));
            var codigoResposta = post.EnsureSuccessStatusCode();

            Console.WriteLine(codigoResposta);

            return codigoResposta;
        }

        public async Task<Boolean> ConsultarComParametro(string cep)
        {
            httpClient.BaseAddress = new System.Uri("https://localhost:44379/api/");
            HttpResponseMessage resposta = await httpClient.GetAsync($"Enderecos/{cep}");
            //resposta.EnsureSuccessStatusCode();

            //var endereco = await resposta.Content.ReadAsStringAsync();

            //var conversao = JsonConvert.DeserializeObject<Endereco>(endereco);

            var retorno = resposta.IsSuccessStatusCode;

            return retorno;
        }

        public async Task <List<Endereco>> ConsultarEndereco()
        {
            

            httpClient.BaseAddress = new System.Uri("https://localhost:44379/api/");
            HttpResponseMessage resposta = await httpClient.GetAsync($"Enderecos");
            resposta.EnsureSuccessStatusCode();

            var endereco = await resposta.Content.ReadAsStringAsync();

            var conversao = JsonConvert.DeserializeObject<List<Endereco>>(endereco);

            return conversao;
        }

        public async Task<HttpResponseMessage> ExcluirEndereco(string cep)
        {
            httpClient.BaseAddress = new System.Uri("https://localhost:44379/api/");

            var response = await httpClient.DeleteAsync($"Enderecos/{cep}");
             return response.EnsureSuccessStatusCode();
        }
    }
}
