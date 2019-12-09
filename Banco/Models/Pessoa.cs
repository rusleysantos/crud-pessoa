using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public int Cpf { get; set; }
        public List<Endereco> Endereco { get; set; }
    }
}
