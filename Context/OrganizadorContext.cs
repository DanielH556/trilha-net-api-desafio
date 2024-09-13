using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
        }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer("Server=localhost,1433");

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}