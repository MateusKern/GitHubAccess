using GitHubAccess.Dominio.Comandos;
using GitHubAccess.Dominio.Manipuladores;
using Microsoft.AspNetCore.Mvc;

namespace GitHubAccess.Controllers
{
    /// <summary>
    /// GitHub
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        private readonly GitHubManipulador _gitHubManipulador;

        public GitHubController(GitHubManipulador gitHubManipulador)
        {
            _gitHubManipulador = gitHubManipulador;
        }

        /// <summary>
        /// Faz a busca de repositórios destaque de 5 linguagens 
        /// </summary>
        /// <returns>Uma lista de repositórios</returns>
        [HttpGet(Name = "busca-lista-repos")]
        public async Task<IActionResult> Get() =>
            Ok(await _gitHubManipulador.ManipularAsync(new BuscarRepositoriosComando()));
    }
}
