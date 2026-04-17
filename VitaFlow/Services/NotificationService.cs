using projeto_carlos.Enums;

namespace projeto_carlos.Services
{
    public class NotificationService
    {
        public event Action<string, ENotificationType>? OnShow;
        public event Action? OnHide;
        public (string Message, ENotificationType Type)? PendingNotification { get; private set; }

        private CancellationTokenSource? _delayCts;

        public void Notify(string message, ENotificationType type = ENotificationType.Info)
        {
            _delayCts?.Cancel();
            _delayCts = new CancellationTokenSource();

            OnShow?.Invoke(message, type);
            
            if (OnShow == null)
            {
                PendingNotification = (message, type);
            }

            // Auto-hide after 5 seconds
            var token = _delayCts.Token;
            Task.Delay(5000, token).ContinueWith(t =>
            {
                if (!t.IsCanceled)
                {
                    OnHide?.Invoke();
                }
            }, token);
        }

        public void Hide()
        {
            _delayCts?.Cancel();
            OnHide?.Invoke();
            PendingNotification = null;
        }

        public void ClearPending() => PendingNotification = null;
    }
}
