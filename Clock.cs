using System;

namespace Clock3
{
	public class Clock
	{
		Counter seconds;
		Counter minutes;
		Counter hours;

		public Clock ()
		{
			seconds = new Counter();
			minutes = new Counter();
			hours = new Counter();
		}

		public void tick()
		{
			seconds.increment ();
			if (seconds.Count == 60) 
			{   
				seconds.Count = 0;
				minutes.increment ();

				if (minutes.Count == 60) 
				{
					minutes.Count = 0;
					hours.increment ();
				}

				if (hours.Count == 24)
					hours.Count = 0;
			}
		}

		public string getTime()
		{
			string result;

			result = hours.Count.ToString("00") + ":"
				+ minutes.Count.ToString("00") + ":" + seconds.Count.ToString("00");

			return result;
		}

		public void reset()
		{
			hours.Count = 0;
			minutes.Count = 0;
			seconds.Count = 0;
		}
	}


}

