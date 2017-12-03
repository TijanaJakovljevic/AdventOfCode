using System;

namespace CorruptionChecksum
{
	public class Range
	{
		public int Min;
		public int Max;
		public int Difference => Math.Abs(Max - Min);

		public Range()
		{
			Min = 9;
			Max = 1;
		}
	}
}