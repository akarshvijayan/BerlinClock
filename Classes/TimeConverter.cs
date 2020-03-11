using BerlinClock.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            TimeFormatCreator factory = new ConcereteTimeFormatCreator();

            TimeFormatInterface inputFormat = factory.SetTimeFormat(TimeFormat.Simple);

            Time inputTime = inputFormat.SetInput(aTime);

            TimeFormatInterface outputFormat = factory.GetTimeFormat(TimeFormat.BerlinClock);

            string outputTIme = outputFormat.GetOutput(inputTime);

            return outputTIme;
        }
	}
}
