using Microsoft.EntityFrameworkCore;
using vet_gestor_api.Models; // Altere para o namespace correto dos seus modelos

namespace vet_gestor_api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        // Adicione os DbSet dos outros modelos aqui
    }
}
