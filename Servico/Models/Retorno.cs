using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class Retorno
    {
        public string Estado { get; set; }
        public int? Id { get; set; }
        public string Mensagem { get; set; }
    }
}
