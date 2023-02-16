using GitHubAccess.Base;
using Octokit;

namespace GitHubAccess.Dominio.Resultados
{
    public class BuscarRepositoriosResultado : Resultado
    {
        public BuscarRepositoriosResultado()
        {
            Repositorios = new();
        }

        public List<Repository> Repositorios { get; set; }
    }
}
