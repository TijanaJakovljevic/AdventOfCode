﻿using CorruptionChecksum;
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

			yield return new object[]
			{
				new List<List<int>>
				{
					new List<int> {1, 1, 1, 4, 5, 5, 1, 9, 5, 101},
					new List<int> {7, 5, 3, 3,4, 4, 4, 4, 3, 6, 103},
					new List<int> {2, 4, 6, 8, 4, 4, 4, 4, 6, 6, 7, 6, 102}
				}, 300
			};
			yield return new object[]
			{
				new List<List<int>>
				{
					new List<int> {121, 59, 141, 21, 120, 67, 58, 49, 22, 46, 56, 112, 53, 111, 104, 130},
					new List<int> {1926, 1910, 760, 2055, 28, 2242, 146, 1485, 163, 976, 1842, 1982, 137, 1387, 162, 789},
					new List<int> {4088, 258, 2060, 1014, 4420, 177, 4159, 194, 2794, 4673, 4092, 681, 174, 2924, 170, 3548},
					new List<int> {191, 407, 253, 192, 207, 425, 580, 231, 197, 382, 404, 472, 164, 571, 500, 21},
					new List<int> {4700, 1161, 168, 5398, 5227, 5119, 252, 2552, 4887, 5060, 1152, 3297, 847, 4525, 220, 262},
					new List<int> {2417, 992, 1445, 184, 554, 2940, 209, 2574, 2262, 1911, 2923, 204, 2273, 2760, 506, 157},
					new List<int> {644, 155, 638, 78, 385, 408, 152, 360, 588, 618, 313, 126, 172, 220, 217, 161},
					new List<int> {227, 1047, 117, 500, 1445, 222, 29, 913, 190, 791, 230, 1281, 1385, 226, 856, 1380},
					new List<int> {436, 46, 141, 545, 122, 86, 283, 124, 249, 511, 347, 502, 168, 468, 117, 94},
					new List<int> {2949, 3286, 2492, 2145, 1615, 159, 663, 1158, 154, 939, 166, 2867, 141, 324, 2862, 641},
					new List<int> {1394, 151, 90, 548, 767, 1572, 150, 913, 141, 1646, 154, 1351, 1506, 1510, 707, 400},
					new List<int> {646, 178, 1228, 1229, 270, 167, 161, 1134, 193, 1312, 1428, 131, 1457, 719, 1288, 989},
					new List<int> {1108, 1042, 93, 140, 822, 124, 1037, 1075, 125, 941, 1125, 298, 136, 94, 135, 711},
					new List<int> {112, 2429, 1987, 2129, 2557, 1827, 477, 100, 78, 634, 352, 1637, 588, 77, 1624, 2500},
					new List<int> {514, 218, 209, 185, 197, 137, 393, 555, 588, 569, 710, 537, 48, 309, 519, 138},
					new List<int> {1567, 3246, 4194, 151, 3112, 903, 1575, 134, 150, 4184, 3718, 4077, 180, 4307, 4097, 1705},
				},
				32264
			};
		}
	}
}