using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.GerenciarPessoa
{

    public class AlterarPessoa
    {
        private ContextoApi _contexto;

        public AlterarPessoa(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        public Retorno Alterar(Pessoa pessoa)
        {
            try
            {
                _contexto.Pessoas.Update(pessoa);
                _contexto.SaveChanges();

                return new Retorno
                {
                    Estado = "Sucesso",
                    Id = pessoa.Id,
                    Mensagem = "Usuário alterado com sucesso"
                };
            }
            catch
            {
                return new Retorno
                {
                    Estado = "Erro",
                    Mensagem = "Erro ao alterar pessoa"
                };
            }
        }
    }
}
