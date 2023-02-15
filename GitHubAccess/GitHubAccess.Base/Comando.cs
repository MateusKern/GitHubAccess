using Flunt.Notifications;

namespace GitHubAccess.Base
{
    public abstract class Comando : Notifiable<Notification>
    {
        public abstract void Validate();
    }
}
