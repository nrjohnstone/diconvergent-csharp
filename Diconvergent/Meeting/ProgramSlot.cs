using System;

namespace Diconvergent.Meeting
{    
    public class ProgramSlot
    {
        private DateTime _start;
        private DateTime _end;
        private String _title;
        private String _room;
        
        public ProgramSlot(DateTime start, DateTime end, String title, String room)
        {
            _start = start;
            _end = end;
            _title = title;
            _room = room;
        }
    }
}