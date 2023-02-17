using GitHubAccess.Base;

namespace GitHubAccess.Dominio.Comandos
{
    public class BuscarRepositoriosComando : Comando
    {
        public override void Validate()
        {
            /* Se tiver algo para ser validado que não precise de componentes externos (banco de dados, acesso a APIs externas...)
            AddNotification("Campo", "Mensgam de erro");
             */
        }
    }
}
