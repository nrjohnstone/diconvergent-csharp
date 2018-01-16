using System;

namespace Diconvergent.Meeting
{
    public class Meeting
    {
        private Guid _meetingId;
        private String _title;
        private String _description;
        private DateTime _start;
        private DateTime _end;
        private Program _program;
        
        public Meeting(
            Guid meetingId,
            String title,
            String description,
            DateTime start,
            DateTime end,
            Program program
        ) {
            _meetingId = meetingId;
            _title = title;
            _description = description;
            _start = start;
            _end = end;
            _program = program;
        }
    }
}