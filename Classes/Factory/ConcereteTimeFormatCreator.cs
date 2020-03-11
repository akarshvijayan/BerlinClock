using BerlinClock.Classes.Enum;
using System;

namespace BerlinClock
{
	public class ConcereteTimeFormatCreator:TimeFormatCreator
	{
		//Dependency Injection for Setting the input Time Format
		public override TimeFormatInterface SetTimeFormat(TimeFormat format)
		{
			switch (format)
			{
				case TimeFormat.Simple: return new FormatSimple();
				default: return new FormatDefault();
			}
		}

		//Dependency Injection for Setting the output Time Format
		public override TimeFormatInterface GetTimeFormat(TimeFormat format)
		{
			switch (format)
			{
				case TimeFormat.Simple: return new FormatSimple();	
				case TimeFormat.BerlinClock : return new FormatBerlinClock();
				default: return new FormatDefault();
			}
		}
	}
}

