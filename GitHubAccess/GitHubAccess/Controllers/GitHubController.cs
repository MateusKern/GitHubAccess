using Microsoft.AspNetCore.Mvc;
using Octokit;

namespace GitHubAccess.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {

        [HttpGet(Name = "busca-lista-repos")]
        public async Task<IActionResult> Get()
        {
            List<Repository> repositorios = new List<Repository>();

            repositorios.Add(await BuscaRepositorioGitHub(Language.CSharp));
            repositorios.Add(await BuscaRepositorioGitHub(Language.Python));
            repositorios.Add(await BuscaRepositorioGitHub(Language.JavaScript));
            repositorios.Add(await BuscaRepositorioGitHub(Language.Java));
            repositorios.Add(await BuscaRepositorioGitHub(Language.Css));

            return Ok(repositorios);
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
