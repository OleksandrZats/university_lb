using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
	class MP3
	{
        private const uint MaxVolume = 100;
        public uint CurrentVolume { get; set; }

        public void IncreaseVolume()
        {
            if (CurrentVolume < 100)
            {
                CurrentVolume++;
            }
        }

        public void ReduceVolume()
        {
            if (CurrentVolume > 0)
            {
                CurrentVolume--;
            }
        }

        public void Mute()
        {
            CurrentVolume = 0;
        }
    }
}
