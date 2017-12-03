using System.Collections.Generic;
using System.Linq;
using CorruptionChecksum;
using FluentAssertions;
using Xunit;

namespace CorruptionChecksumTests
{
	public class UnitTest1
	{
		[Theory]
		[MemberData(nameof(RowExamples))]
		public void CalculateRowMinMaxDifference(List<int> row, int expected)
		{
			var range = row.CalculateRange();

			var difference = range.CalculateRowDifference();

			difference.Should().Be(expected);
		}

		public static IEnumerable<object[]> RowExamples()
		{
			yield return new object[] {new List<int> {5, 1, 9, 5}, 8};
			yield return new object[] {new List<int> {7, 5, 3}, 4};
			yield return new object[] {new List<int> {2, 4, 6, 8}, 6};
		}
	}
}