using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Infra.Contexto;
using Microsoft.EntityFrameworkCore;

namespace GitHubAccess.Infra.Repositorios
{
    public class GitHubRepositorio : IGitHubRepositorio
    {
        private readonly BdContexto _bdContexto;

        public GitHubRepositorio(BdContexto bdContexto)
        {
            _bdContexto = bdContexto;
        }

        public async Task AdicionarLista(IEnumerable<Dominio.Entidades.GitHubRepositorio> entities) =>
            await _bdContexto.GitHubRepositorio.AddRangeAsync(entities);

        public async Task<IEnumerable<Dominio.Entidades.GitHubRepositorio>> ObterTodos() =>
            await _bdContexto.GitHubRepositorio.ToListAsync();

        public async Task Commit() =>
            await _bdContexto.SaveChangesAsync();
    }
}
