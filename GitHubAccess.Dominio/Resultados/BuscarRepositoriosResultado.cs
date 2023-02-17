using GitHubAccess.Base;
using GitHubAccess.Dominio.Entidades;

namespace GitHubAccess.Dominio.Resultados
{
    public class BuscarRepositoriosResultado : Resultado
    {
        public BuscarRepositoriosResultado()
        {
            Repositorios = new();
        }

        public List<GitHubRepositorio> Repositorios { get; set; }
    }
}
