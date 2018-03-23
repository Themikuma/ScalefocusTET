using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses.HR
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Status Status { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public int Experience
        {
            get
            {
                TimeSpan span = new TimeSpan(DateTime.Now.Ticks - StartDate.Ticks);
                return span.Days;
            }
        }
    }
}
