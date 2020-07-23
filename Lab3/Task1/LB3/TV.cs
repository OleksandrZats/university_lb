using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
	class TV
	{
        public uint CurrentChannel { get; set; }

        public void NextChannel()
        {
            CurrentChannel++;
        }

        public void PreviousChannel()
        {
            if (CurrentChannel > 0)
            {
                CurrentChannel--;
            }
        }

        public void GoToChannelByNumber(uint number)
        {
            CurrentChannel = number;
        }
    }
}
