using System;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; } = string.Empty; // Initialize UserName
        public DateTime SessionStartTime { get; private set; }

        public event Action? OnSessionChanged;

        public void StartSession(string userName)
        {
            UserName = userName;
            SessionStartTime = DateTime.Now;
            NotifySessionChanged();
        }

        public void EndSession()
        {
            UserName = string.Empty; // Clear UserName
            SessionStartTime = DateTime.MinValue;
            NotifySessionChanged();
        }

        public bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(UserName);
        }

        private void NotifySessionChanged()
        {
            OnSessionChanged?.Invoke();
        }
    }
}
