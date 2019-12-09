using Banco.Models;
using CadastroPessoa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.GerenciarEndereco
{
    public class InserirEndereco
    {

        private ContextoApi _contexto;

        public InserirEndereco(ContextoApi contexto)
        {
            _contexto = contexto;
        }

        public Retorno Inserir(Endereco endereco)
        {
            try
            {
                _contexto.Add(endereco);
                _contexto.SaveChanges();

                return new Retorno
                {
                    Estado = "Sucesso",
                    Id = endereco.Id,
                    Mensagem = "Endereço inserido com sucesso"
                };
            }
            catch
            {
                //TODO: Inserir notificação para o slack
                return new Retorno
                {
                    Estado = "Erro",
                    Mensagem = "Erro ao inserir endereço"
                };
            }
        }
    }
}
