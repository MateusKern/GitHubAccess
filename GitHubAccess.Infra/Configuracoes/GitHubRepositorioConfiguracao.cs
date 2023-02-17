using GitHubAccess.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GitHubAccess.Infra.Configuracoes
{
    public class GitHubRepositorioConfiguracao : IEntityTypeConfiguration<GitHubRepositorio>
    {
        public void Configure(EntityTypeBuilder<GitHubRepositorio> builder)
        {
            builder.HasKey(e => e.BdId);
            builder.Property(e => e.Topics)
                   .HasConversion(
                       v => string.Join(',', v),
                       v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
