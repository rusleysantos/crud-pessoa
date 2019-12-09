using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.GerenciarPessoa
{
    public class ObterPessoa
    {
        private ContextoApi _contexto;

        public ObterPessoa(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Obtem todos os usuários cadastrados no sistema sem paginação.
        /// </summary>
        /// <returns>Todos cadastrados no banco</returns>
        public List<Pessoa> ObterTodos()
        {
            List<Pessoa> pessoas = _contexto.Pessoas.ToList();
            return pessoas;
        }

        /// <summary>
        /// Obtem usuário por cpf
        /// </summary>
        /// <param name="Cpf">Cpf do usuário</param>
        /// <returns>Usuário de um Cpf específico</returns>
        public Pessoa ObterPorCpf(int Cpf)
        {
            Pessoa pessoaa = _contexto.Pessoas.Where(x => x.Cpf == Cpf).First();
            return pessoaa;
        }
    }
}

