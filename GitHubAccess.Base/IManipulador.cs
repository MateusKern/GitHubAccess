namespace GitHubAccess.Base
{
    public interface IManipulador<T> where T : Comando
    {
        Task<Resultado> ManipularAsync(T comando);
    }
}
