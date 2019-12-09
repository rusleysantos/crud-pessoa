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
        public InserirPessoa _inserirPessoa { get; set; }

        PessoaController(InserirPessoa inserirPessoa)
        {
            _inserirPessoa = inserirPessoa;
        }

        [HttpGet("inserir")]
        public ActionResult InserirPessoa([FromBody] Pessoa pessoa)
        {
            _inserirPessoa.Inserir(pessoa);
            return View();
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


    }
}