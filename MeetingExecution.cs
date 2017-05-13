using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackwithInterface
{
    public class MeetingExecution
    {
        public void PerformMeeting()
        {
            IMeeting meeging = new Meeting();
            MeetingRoom meetingStarted = new MeetingRoom("Code Quality Improvement.");
            meetingStarted.StartMeeting(meeging);
        }
    }
}
