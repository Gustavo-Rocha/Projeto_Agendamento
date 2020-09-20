using Agendamento.Models;
using Agendamento.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Controllers
{
    public class ConsultaClienteController
    {

        private readonly IConsultaCliente consultaRepository;

            public ConsultaClienteController(IConsultaCliente consultaCliente)
            {

                this.consultaRepository = consultaCliente;
        
            }


        //public IActionResult ResultadoConsulta()
        //{

        //     return View();

        //}



    }
}
