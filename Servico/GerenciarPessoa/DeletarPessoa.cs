using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.GerenciarPessoa
{
    public class DeletarPessoa
    {
        private ContextoApi _contexto;

        public DeletarPessoa(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Deleta usuário
        /// </summary>
        /// <param name="pessoa">Pessoa a ser deletada</param>
        /// <returns>Objeto de retorno com informações sobre a deleção</returns>
        public Retorno Deletar(Pessoa pessoa)
        {
            try
            {
                _contexto.Pessoas.Remove(pessoa);
                return new Retorno { Estado = "Sucesso", Id = pessoa.Id, Mensagem = "Usuário removido com sucesso" };
            }
            catch
            {
                return new Retorno { Estado = "Erro", Mensagem = "Erro ao remover usuário" };
            }
        }
    }
}
