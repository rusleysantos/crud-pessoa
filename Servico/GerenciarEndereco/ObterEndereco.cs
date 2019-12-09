using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Servico.GerenciarEndereco
{
    public class ObterEndereco
    {
        private ContextoApi _contexto;
        public ObterEndereco(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        public List<Endereco> ObterEnderecoPorIdPessoa(int id)
        {
            List<Endereco> enderecos = _contexto.Enderecos
                                        .Where(x => x.PessoaId == id)
                                        .ToList();
                
            return enderecos;
        }
    }
}
