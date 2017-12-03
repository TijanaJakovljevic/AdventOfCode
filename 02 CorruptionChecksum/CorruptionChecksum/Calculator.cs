using System.Collections.Generic;
using System.Linq;

namespace CorruptionChecksum
{
	public static class Calculator
	{
		public static int CalculateRowDifference(this List<int> row)
		{
			var range = row.CalculateRange();

			return range.Difference;
		}

		public static int CalculateChecksum(this List<List<int>> spreadsheet)
		{
			return spreadsheet.Aggregate(0, (acc, row) => acc + row.CalculateRange().Difference);
		}

		public static Range CalculateRange(this List<int> row)
		{
			return row.Aggregate(new Range(), (res, num) =>
				{
					if (num > res.Max)
						res.Max = num;

					if (num < res.Min)
						res.Min = num;

					return res;
				}
			);
		}
	}
}