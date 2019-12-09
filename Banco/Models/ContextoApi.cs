using CadastroPessoa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco.Models
{
    public class ContextoApi: DbContext
    {
        public ContextoApi(DbContextOptions options) : base(options)
        {
        }

        DbSet<Endereco> Enderecos { get; set; }
        DbSet<Pessoa> Pessoas { get; set; }
    }
}
