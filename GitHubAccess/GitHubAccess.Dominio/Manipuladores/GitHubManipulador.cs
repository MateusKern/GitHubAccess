using GitHubAccess.Base;
using GitHubAccess.Dominio.Comandos;
using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Dominio.Resultados;

namespace GitHubAccess.Dominio.Manipuladores
{
    public class GitHubManipulador : IManipulador<BuscarRepositoriosComando>
    {
        private readonly IGitHubServico _gitHubServico;

        public GitHubManipulador(IGitHubServico gitHubServico)
        {
            _gitHubServico = gitHubServico;
        }

        public async Task<Resultado> ManipularAsync(BuscarRepositoriosComando comando)
        {
            BuscarRepositoriosResultado resultado = new();

            comando.Validate();
            if (!comando.IsValid)
            {
                resultado.AddNotifications(comando);
                return resultado;
            }

            resultado.Repositorios.AddRange(await _gitHubServico.BuscarRepositorios());

            return resultado;
        }
    }
}
