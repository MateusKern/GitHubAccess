using GitHubAccess.Base;
using GitHubAccess.Dominio.Comandos;
using GitHubAccess.Dominio.Interfaces;
using GitHubAccess.Dominio.Resultados;

namespace GitHubAccess.Dominio.Manipuladores
{
    public class GitHubManipulador : IManipulador<BuscarRepositoriosComando>
    {
        private readonly IGitHubServico _gitHubServico;
        private readonly IGitHubRepositorio _gitHubRepositorio;

        public GitHubManipulador(IGitHubServico gitHubServico, IGitHubRepositorio gitHubRepositorio)
        {
            _gitHubServico = gitHubServico;
            _gitHubRepositorio = gitHubRepositorio;
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

            var repositorios = await _gitHubRepositorio.ObterTodos();

            if (repositorios == null || !repositorios.Any())
            {
                repositorios = await _gitHubServico.BuscarRepositorios();
                await _gitHubRepositorio.AdicionarLista(repositorios);
                await _gitHubRepositorio.Commit();
            }

            resultado.Repositorios.AddRange(repositorios);

            return resultado;
        }
    }
}
