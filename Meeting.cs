using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackwithInterface
{
    public class Meeting : IMeeting
    {
        public void ShowAgenda(string agenda)
        {
            Console.WriteLine("Agenda Details: " + agenda);
        }

        public void EmployeeAttendedMeeting(string employee)
        {
            Console.WriteLine("Employee Attended Meeting: " + employee);
        }

        public void EmployeeLeftMeeting(string employee)
        {
            Console.WriteLine("Employee Left Meeting: " + employee);
        }
    }
}
