using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
	class Refrigerator
	{
        private OperatingModes Mode { get; set; }

        public Refrigerator()
        {
            Mode = OperatingModes.Off;
        }

        public OperatingModes GetCurrentMode()
        {
            return Mode;
        }

        public void SetMode(OperatingModes mode)
        {
            Mode = mode;
        }
    }
}
