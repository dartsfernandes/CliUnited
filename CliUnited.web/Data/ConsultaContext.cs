using Microsoft.EntityFrameworkCore;
using CliUnited.web.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CliUnited.web.Data
{
    public class ConsultaContext : DbContext
    {
        public ConsultaContext(DbContextOptions<ConsultaContext> options)
            : base(options)
        {
        }

        public DbSet<Consulta> Consulta { get; set; }

    }
}
