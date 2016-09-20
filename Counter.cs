using System;

namespace Clock3
{
	public class Counter
	{
		private int _count;

		public int Count
		{
			get { return _count;}
			set { _count = value; }
		}


		public Counter ()
		{
			_count = 0;
		}

		public void increment()
		{
			_count++;
		}
	}
}

