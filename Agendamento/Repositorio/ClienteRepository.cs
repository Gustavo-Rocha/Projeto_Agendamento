using Agendamento.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Repositorio
{
    public class ClienteRepository:IClienteRepository
    {
        public ClienteRepository(ApplicationContext context) 
        {
        }

        

        public void Cadastrar(Cliente cliente)
        {
            // var cliente = new Cliente();

            var context = new ApplicationContext();
            

                //cliente.cpf = 1234455;
                //cliente.Nome = "Gustavo Oliveira";
                //cliente.Celular = 9527532;
                //cliente.Email = "gustavo@hotmail.com";


                context.Clientes.Add(cliente);

                context.SaveChanges();

        }


        public void ExcluirCliente(string cpf)
        {
            var context = new ApplicationContext();
            //var idCLiente = cliente.Id;
            //codigo = (int)codigo;
            var clienteExcluir = context.Clientes.Where(c=>c.Cpf== cpf).SingleOrDefault();

            context.Clientes.Remove(clienteExcluir);
            context.SaveChanges();

        }

        public void AlterarCliente(Cliente cliente)
        {
            var context = new ApplicationContext();
            var idCLiente = cliente.Cpf;

            var clienteAlterar = context.Clientes.Where(c => c.Cpf == idCLiente).SingleOrDefault();

            


            ////cliente.Id = 1;
            clienteAlterar.Cpf = "123450000";
            clienteAlterar.Nome = "Gustavo Oliveira Rocha";
            clienteAlterar.Celular = "9527532";
            clienteAlterar.Email = "gustavo@hotmail.com";

            context.Update(clienteAlterar);

            context.SaveChanges();



        }

        public IList<Cliente> ConsultarCliente()
        {
            var context = new ApplicationContext();
            return context.Clientes.ToList();

        }

        public Cliente ConsultarClientePorParametro(string cpf)
        {
            var context = new ApplicationContext();
            return context.Clientes.Find(cpf);

            
        }
    }
}
