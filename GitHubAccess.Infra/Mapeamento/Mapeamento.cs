using AutoMapper;
using GitHubAccess.Dominio.Entidades;
using Octokit;

namespace GitHubAccess.Infra.Mapeamento
{
    public class Mapeamento : Profile
    {
        public Mapeamento()
        {
            CreateMap<Repository, GitHubRepositorio>();
        }
    }
}
