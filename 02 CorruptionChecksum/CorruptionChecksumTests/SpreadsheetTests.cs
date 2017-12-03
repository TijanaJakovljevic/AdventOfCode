using CorruptionChecksum;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CorruptionChecksumTests
{
	public class SpreadsheetTests
	{
		[Theory]
		[MemberData(nameof(SpreadsheetExamples))]
		public void CalculateRowMinMaxDifference(List<List<int>> spreadsheet, int expected)
		{
			var checksum = spreadsheet.CalculateChecksum();

			checksum.Should().Be(expected);
		}

		public static IEnumerable<object[]> SpreadsheetExamples()
		{
			yield return new object[]
			{
				new List<List<int>>
				{
					new List<int> {5, 1, 9, 5},
					new List<int> {7, 5, 3},
					new List<int> {2, 4, 6, 8},
				},
				18
			};
		}
	}
}