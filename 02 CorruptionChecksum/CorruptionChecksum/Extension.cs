using System;
using System.Collections.Generic;
using System.Linq;

namespace CorruptionChecksum
{
    public static class Extension
    {
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
