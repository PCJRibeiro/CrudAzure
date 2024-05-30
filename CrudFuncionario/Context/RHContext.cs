using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CrudFuncionario.Models;

namespace CrudFuncionario.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
