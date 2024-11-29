using Microsoft.EntityFrameworkCore;
using Livraria.Models;

namespace Livraria.Context
{
    public class AppDbContext : DbContext
    {

        //Herdando aqui de options 
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Editora> Editora { get; set; }
        public DbSet<Escritor> Escritors { get; set; }
        public DbSet<Genero> Generes { get; set; }  
        public DbSet<Livro> Livro { get; set; }

    }
}