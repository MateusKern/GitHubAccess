using GitHubAccess.Base;
using GitHubAccess.Dominio.Comandos;
using GitHubAccess.Dominio.Resultados;
using Octokit;

namespace GitHubAccess.Dominio.Manipuladores
{
    public class GitHubManipulador : IManipulador<BuscarRepositoriosComando>
    {
        public async Task<Resultado> ManipularAsync(BuscarRepositoriosComando comando)
        {
            BuscarRepositoriosResultado resultado = new();

            comando.Validate();
            if (!comando.IsValid)
            {
                resultado.AddNotifications(comando);
                return resultado;
            }

            resultado.Repositorios.Add(await BuscaRepositorioGitHub(Language.CSharp));
            resultado.Repositorios.Add(await BuscaRepositorioGitHub(Language.Python));
            resultado.Repositorios.Add(await BuscaRepositorioGitHub(Language.JavaScript));
            resultado.Repositorios.Add(await BuscaRepositorioGitHub(Language.Java));
            resultado.Repositorios.Add(await BuscaRepositorioGitHub(Language.Css));

            return resultado;
        }

        private async Task<Repository> BuscaRepositorioGitHub(Language language)
        {
            var githubClient = new GitHubClient(new ProductHeaderValue("GitHubAccess"));

            var request = new SearchRepositoriesRequest
            {
                Language = language,
                SortField = RepoSearchSort.Stars,
                Order = SortDirection.Descending,
                PerPage = 1,
                Page = 1
            };

            return (await githubClient.Search.SearchRepo(request)).Items[0];
        }
    }
}
