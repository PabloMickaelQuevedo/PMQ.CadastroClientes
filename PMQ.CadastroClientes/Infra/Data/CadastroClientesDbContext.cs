using Microsoft.EntityFrameworkCore;
using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Infra.Data
{
    public class CadastroClientesDbContext : DbContext
    {
        public CadastroClientesDbContext(DbContextOptions<CadastroClientesDbContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
