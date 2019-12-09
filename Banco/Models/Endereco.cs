using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoa.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
    }
}
