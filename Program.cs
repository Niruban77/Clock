using System;

namespace Clock3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Clock myClock = new Clock();

			Console.WriteLine (myClock.getTime());

			for (int i = 0; i < 4000; i++) {

				Console.WriteLine (myClock.getTime ());
				myClock.tick ();
			}
			Console.ReadLine ();

		}
	}
}
