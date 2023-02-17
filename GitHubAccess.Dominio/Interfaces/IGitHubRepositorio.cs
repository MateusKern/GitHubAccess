using GitHubAccess.Dominio.Entidades;

namespace GitHubAccess.Dominio.Interfaces
{
    public interface IGitHubRepositorio
    {
        Task AdicionarLista(IEnumerable<GitHubRepositorio> entities);
        Task<IEnumerable<GitHubRepositorio>> ObterTodos();
        Task Commit();
    }
}
