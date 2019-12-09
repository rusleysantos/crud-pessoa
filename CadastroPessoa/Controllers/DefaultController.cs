using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroPessoa.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        /// <summary>
        /// Rota inicial da aplicação
        /// </summary>
        /// <returns></returns>
        [HttpGet("inicial")]
        public ActionResult Index()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var retorno = String.Format("Bem-vindo ao Cadastro de Pessoa. Isso demorou {0} ms para carregar", sw.Elapsed.Milliseconds);
            sw.Stop();

            return Ok(retorno);
        }
    }
}