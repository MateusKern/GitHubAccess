using GitHubAccess.Dominio.Entidades;

namespace GitHubAccess.Dominio.Interfaces
{
    public interface IGitHubServico
    {
        public Task<List<GitHubRepositorio>> BuscarRepositorios();
    }
}
