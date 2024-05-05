using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDataLayer
{
    public class Event
    {
        public required string EventId { get; set; }
        public required string EventName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //  0 or more events can be associated with one state
        public State State { get; set; }

        //  0 or more events can be associated with one user
        public User User { get; set; }
    }
}
