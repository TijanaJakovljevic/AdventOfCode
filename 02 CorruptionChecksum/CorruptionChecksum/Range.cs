using System;

namespace CorruptionChecksum
{
	public class Range
	{
		public int Min;
		public int Max;

		public Range()
		{
			Min = 9;
			Max = 1;
		}

		public int CalculateRowDifference()
		{
			return Math.Abs(Max - Min);
		}
	}
}