using BerlinClock.Classes.Enum;
using System;

namespace BerlinClock
{
	public abstract class TimeFormatCreator
	{
		//Gets the Input Time Format
		public abstract TimeFormatInterface SetTimeFormat(TimeFormat format);

		//Gets the Output Time Format
		public abstract TimeFormatInterface GetTimeFormat(TimeFormat format);
	}
}

