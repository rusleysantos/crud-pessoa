using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servico.GerenciarEndereco;

namespace CadastroPessoa.Controllers
{
    public class EnderecoController : Controller
    {
        private InserirEndereco _inserirEndereco;
        private ObterEndereco _obterEndereco;

        public EnderecoController(InserirEndereco inserirEndereco,
                                ObterEndereco obterEndereco)
        {
            _inserirEndereco = inserirEndereco;
            _obterEndereco = obterEndereco;

        }

        [HttpPost]
        public ActionResult Post([FromBody] Endereco endereco)
        {
            return Ok(_inserirEndereco.Inserir(endereco));
        }

        [HttpGet("ObterEnderecoPorIdPessoa/{Id}")]
        public ActionResult ObterEnderecoPorIdPessoa(int Id)
        {
            return Ok(_obterEndereco.ObterEnderecoPorIdPessoa(Id));
        }
    }
}