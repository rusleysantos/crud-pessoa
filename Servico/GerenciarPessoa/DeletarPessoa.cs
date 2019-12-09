using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Retorno Deletar(int Cpf)
        {
            try
            {
                _contexto.Remove(_contexto.Pessoas.Single(a => a.Cpf == Cpf));
                _contexto.SaveChanges();
                return new Retorno { Estado = "Sucesso", Mensagem = "Usuário removido com sucesso" };
            }
            catch(Exception e)
            {
                return new Retorno { Estado = "Erro", Mensagem = "Erro ao remover usuário" };
            }
        }
    }
}
