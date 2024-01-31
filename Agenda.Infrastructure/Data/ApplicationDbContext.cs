using Agenda.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Agenda.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Lista_Tarefas> Listas_Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lista_Tarefas>().HasData(
                new Lista_Tarefas
                {
                    Id = 1,
                    Tipo = "Casa",
                    Descrição = "Tarefas a serem feitas em casa",
                },

                new Lista_Tarefas
                {
                    Id = 2,
                    Tipo = "Trabalho",
                    Descrição = "Tarefas relacionadas com trabalho"
                },

                 new Lista_Tarefas
                 {
                     Id = 3,
                     Tipo = "Escola",
                     Descrição = "Tarefas relacionadas com escola"
                 },

                  new Lista_Tarefas
                  {
                      Id = 4,
                      Tipo = "Crianças",
                      Descrição = "Tarefas dos mais pequenos"
                  },

                   new Lista_Tarefas
                   {
                       Id = 5,
                       Tipo = "Animais",
                       Descrição = "Tarefas relacionadas os patudos"
                   },

                    new Lista_Tarefas
                    {
                        Id = 6,
                        Tipo = "Lazer",
                        Descrição = "Tarefas de lazer"
                    }
             );
        }
    }
}
