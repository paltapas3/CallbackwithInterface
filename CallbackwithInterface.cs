using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackwithInterface
{
    public interface IMeeting
    {
        void ShowAgenda(string agenda);
        void EmployeeAttendedMeeting(string employee);
        void EmployeeLeftMeeting(string employee);
    }
    class CallbackwithInterface
    {
        static void Main(string[] args)
        {
            MeetingExecution meetingExecution = new MeetingExecution();
            meetingExecution.PerformMeeting();
            Console.ReadLine();
        }
    }
}
