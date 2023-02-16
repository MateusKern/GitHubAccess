using AutoMapper;
using GitHubAccess.Dominio.Entidades;
using GitHubAccess.Dominio.Interfaces;
using Octokit;

namespace GitHubAccess.Infra.Servicos
{
    public class GitHubServico : IGitHubServico
    {
        private readonly IMapper _mapper;

        public GitHubServico(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<GitHubRepositorio>> BuscarRepositorios()
        {
            List<GitHubRepositorio> repositorios = new()
            {
                await BuscaRepositorioGitHub(Language.CSharp),
                await BuscaRepositorioGitHub(Language.Python),
                await BuscaRepositorioGitHub(Language.JavaScript),
                await BuscaRepositorioGitHub(Language.Java),
                await BuscaRepositorioGitHub(Language.Css)
            };

            return repositorios;
        }

        private async Task<GitHubRepositorio> BuscaRepositorioGitHub(Language language)
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

            return _mapper.Map<GitHubRepositorio>((await githubClient.Search.SearchRepo(request)).Items[0]);
        }
    }
}
