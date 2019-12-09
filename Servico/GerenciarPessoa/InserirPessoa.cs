using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.GerenciarPessoa
{
    public class InserirPessoa
    {

        private ContextoApi _contexto;

        public InserirPessoa(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Método responsável por inserir pessoa.
        /// </summary>
        /// <param name="pessoa">Pessoa inserida pelo usuário</param>
        /// <returns>True: Inserido com sucesso e False: Erro ao inserir</returns>
        public Retorno Inserir(Pessoa pessoa)
        {
            try
            {
                _contexto.Add(pessoa);
                _contexto.SaveChanges();

                return new Retorno
                {
                    Estado = "Sucesso",
                    Id = pessoa.Id,
                    Mensagem = "Usuário inserido com sucesso"
                };
            }
            catch
            {
                //TODO: Inserir notificação para o slack
                return new Retorno
                {
                    Estado = "Erro",
                    Mensagem = "Erro ao inserir usuário"
                };
            }
        }
    }
}
