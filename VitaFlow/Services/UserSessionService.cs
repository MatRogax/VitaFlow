using projeto_carlos.Models.Entities;

namespace projeto_carlos.Services
{
    public class UserSessionService
    {
        public User? CurrentUser { get; private set; }
        public bool IsLoggedIn => CurrentUser != null;

        public event Action? OnSessionChanged;

        public void SetUser(User user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        public void ClearSession()
        {
            CurrentUser = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnSessionChanged?.Invoke();
    }
}
