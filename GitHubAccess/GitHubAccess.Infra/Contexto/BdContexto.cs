using GitHubAccess.Dominio.Entidades;
using GitHubAccess.Infra.Configuracoes;
using Microsoft.EntityFrameworkCore;

namespace GitHubAccess.Infra.Contexto
{
    public class BdContexto : DbContext
    {
        public BdContexto(DbContextOptions<BdContexto> options) : base(options) { }
        public BdContexto() { }

        public DbSet<GitHubRepositorio> GitHubRepositorio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GitHubRepositorioConfiguracao());
            base.OnModelCreating(modelBuilder);
        }
    }
}
