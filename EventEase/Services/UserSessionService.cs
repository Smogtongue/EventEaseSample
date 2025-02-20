using System;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; } = string.Empty; // Initialize UserName
        public DateTime SessionStartTime { get; private set; }

        public void StartSession(string userName)
        {
            UserName = userName;
            SessionStartTime = DateTime.Now;
        }

        public void EndSession()
        {
            UserName = string.Empty; // Set UserName to an empty string instead of null
            SessionStartTime = DateTime.MinValue;
        }

        public bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(UserName);
        }
    }
}
