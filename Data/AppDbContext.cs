using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiNet8.Models;

namespace WebApiNet8.Data 
{
    public class AppDbContext : DbContext // meio de campo do banco de dados para o codigo
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }

        public DbSet<AutorModel> Autores { get; set; }

        public DbSet<LivroModel> Livros {get; set; }
    }
}