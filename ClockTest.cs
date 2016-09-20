using NUnit.Framework;
using System;
namespace Clock3
{
	[TestFixture()]
	public class ClockTest
	{
		[Test()]
		public void TestOneSecond()
		{
			Clock myClock = new Clock();
		
			Assert.AreEqual ("00:00:00", myClock.getTime());

			myClock.tick ();

			Assert.AreEqual ("00:00:01", myClock.getTime());
		}

		[Test()]
		public void TestOneMinute()
		{
			Clock myClock = new Clock();

			Assert.AreEqual ("00:00:00", myClock.getTime());

			for (int i = 0; i < 60; i++)
				myClock.tick ();

			Assert.AreEqual ("00:01:00", myClock.getTime());
		}


		[Test()]
		public void TestOneHour()
		{
			Clock myClock = new Clock();

			Assert.AreEqual ("00:00:00", myClock.getTime());

			for (int i = 0; i < 60*60; i++)
				myClock.tick ();

			Assert.AreEqual ("01:00:00", myClock.getTime());
		}

		[Test()]
		public void TestOneDay()
		{
			Clock myClock = new Clock();

			Assert.AreEqual ("00:00:00", myClock.getTime());

			for (int i = 0; i < 24*60*60; i++)
				myClock.tick ();

			Assert.AreEqual ("00:00:00", myClock.getTime());
		}
	}
}

