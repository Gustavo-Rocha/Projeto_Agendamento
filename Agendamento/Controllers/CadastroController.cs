using Agendamento.Models;
using Agendamento.Repositorio;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class CadastroController: Controller
    {

        private readonly IClienteRepository clienteRepository;
        private readonly IConsultaCliente consultaRepository;
        private readonly IEnderecoRepository enderecoRepository;

        public CadastroController(IClienteRepository clienteRepository, IConsultaCliente consultaClienteRepository, 
            IEnderecoRepository enderecoRepository)
        {
            this.clienteRepository = clienteRepository;
            this.consultaRepository = consultaClienteRepository;
            this.enderecoRepository = enderecoRepository;
        }



        public async Task<IActionResult> Index()
        {

            var cliente = new Cliente();
            var endereco = new Endereco();
            //cliente.Id = 2;
            //cliente.Cpf = "81455050";
            //cliente.Nome = "Gustavo Oliveira";
            //cliente.Celular = "9527532";
            //cliente.Email = "gustavo@hotmail.com";
            //cliente.Cep = "01455050";
            

           
            //var codigo = await enderecoRepository.ConsultarComParametro(cliente.Cep);

            //if (codigo.StatusCode.Equals(04))
            //{
            //    Console.WriteLine(codigo);
            //   // return View();
            //}
            //Console.WriteLine(codigo);

           // clienteRepository.Cadastrar(cliente);

            return View();
        }

        public async Task<IActionResult> ResultadoConsulta()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.BaseAddress = new System.Uri("https://localhost:44379/api/");
            HttpResponseMessage resposta = await httpClient.GetAsync($"Enderecos");
            resposta.EnsureSuccessStatusCode();

            var endereco = await resposta.Content.ReadAsStringAsync();

            var conversao = JsonConvert.DeserializeObject<List<Endereco>>(endereco);
            


            return View(conversao);

        }

        [HttpPost]
        public async Task<IActionResult> Exclusao(string Cpf)
        {

            //var cliente = new Cliente();
            //cliente.Id = 3;

            //cliente.cpf = 1234455;
            //cliente.Nome = "Gustavo Oliveira";
            //cliente.Celular = 9527532;
            //cliente.Email = "gustavo@hotmail.com";

            //var cliente = clienteRepository.ConsultarClientePorParametro(Cpf);
            //var response = await enderecoRepository.ExcluirEndereco(cliente);

            clienteRepository.ExcluirCliente(Cpf);


            return View();
        }


        public IActionResult Alteracao()
        {

            var cliente = new Cliente();
            cliente.Cpf = "1";
            

            clienteRepository.AlterarCliente(cliente);
            return View();
        }


        public async Task<IActionResult> Cadastrar(Cliente cliente)
        {

            var codigo = await enderecoRepository.ConsultarComParametro(cliente.Cep);
            HttpStatusCode status;
            

            if (codigo==false
            {
                Console.WriteLine(codigo);
                return View("CEP inválido");
            }
            //Console.WriteLine(codigo);

            clienteRepository.Cadastrar(cliente);

            return View();
        }

    }
}
