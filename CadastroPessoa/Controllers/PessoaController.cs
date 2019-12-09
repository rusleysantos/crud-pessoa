using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroPessoa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servico.GerenciarPessoa;

namespace CadastroPessoa.Controllers
{
    [Route("api/pessoa")]
    public class PessoaController : Controller
    {
        private InserirPessoa _inserirPessoa;
        private ObterPessoa _obterPessoa;
        private DeletarPessoa _deletarPessoa;
        private AlterarPessoa _alterarPessoa;

        public PessoaController(InserirPessoa inserirPessoa,
                                ObterPessoa obterPessoa,
                                DeletarPessoa deletarPessoa,
                                AlterarPessoa alterarPessoa)
        {
            _inserirPessoa = inserirPessoa;
            _obterPessoa = obterPessoa;
            _deletarPessoa = deletarPessoa;
            _alterarPessoa = alterarPessoa;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Pessoa pessoa)
        {
            return Ok(_inserirPessoa.Inserir(pessoa));
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_obterPessoa.ObterTodos());
        }

        [HttpGet("ObterPorCpf/{Cpf}")]
        public ActionResult ObterPorCpf(int Cpf)
        {
            return Ok(_obterPessoa.ObterPorCpf(Cpf));
        }

        [HttpDelete("{Cpf}")]
        public ActionResult Delete(int Cpf)
        {
            return Ok(_deletarPessoa.Deletar(Cpf));
        }

        [HttpPut]
        public ActionResult Put(Pessoa pessoa)
        {
            return Ok(_alterarPessoa.Alterar(pessoa));
        }
    }
}