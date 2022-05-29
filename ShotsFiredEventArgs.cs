using System;

namespace Events_and_Delegates
{
    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeOfKill { get; set; }

        public ShotsFiredEventArgs()
        {
                
        }

        public ShotsFiredEventArgs(DateTime time)
        {
            TimeOfKill = time;
        }
    }
}
