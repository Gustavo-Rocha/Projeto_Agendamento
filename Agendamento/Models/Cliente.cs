using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Models
{
    public class Cliente
    {
        //public int Id { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="CEP Inválido")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Cpf { get; set; }
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }

        [StringLength(8, MinimumLength = 8)]
        public string Celular { get; set; }

        [StringLength(60, MinimumLength = 6)]
        public string Email { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8)]
        public string Cep { get; set; }
        //public IList<Cliente> ListaCliente { get; set; }

    }
}
