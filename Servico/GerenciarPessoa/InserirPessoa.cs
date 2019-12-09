using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.GerenciarPessoa
{
    public class InserirPessoa
    {
        public ContextoApi _contexto { get; set; }

        InserirPessoa(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        public bool Inserir(Pessoa pessoa)
        {
            _contexto.Add(pessoa);
            _contexto.SaveChanges();

            return true;
        }
    }
}
