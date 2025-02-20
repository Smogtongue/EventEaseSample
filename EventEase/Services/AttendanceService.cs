using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, List<string>> attendanceRecords = new();

        public void RegisterAttendance(int eventId, string userName)
        {
            if (!attendanceRecords.ContainsKey(eventId))
            {
                attendanceRecords[eventId] = new List<string>();
            }

            if (!attendanceRecords[eventId].Contains(userName))
            {
                attendanceRecords[eventId].Add(userName);
            }
        }

        public void RemoveAttendance(int eventId, string userName)
        {
            if (attendanceRecords.ContainsKey(eventId))
            {
                attendanceRecords[eventId].Remove(userName);
            }
        }

        public bool IsUserAttending(int eventId, string userName)
        {
            return attendanceRecords.ContainsKey(eventId) && attendanceRecords[eventId].Contains(userName);
        }

        public List<string> GetAttendance(int eventId)
        {
            return attendanceRecords.ContainsKey(eventId) ? attendanceRecords[eventId] : new List<string>();
        }

        public int GetAttendanceCount(int eventId)
        {
            return attendanceRecords.ContainsKey(eventId) ? attendanceRecords[eventId].Count : 0;
        }
    }
}
