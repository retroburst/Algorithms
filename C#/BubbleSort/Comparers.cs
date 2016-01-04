using System;
using System.Collections.Generic;

namespace BubbleSort
{
	public class IntegerComparer : IComparer<int>
	{
		public int Compare (int x, int y)
		{
			if(x == y) return (0);
			if(x > y) return (1);
			else return(-1);
		}
	}

	public class StringOrdinalComparer : IComparer<string>
	{
		public int Compare (string x, string y)
		{
			return(string.Compare(x, y, StringComparison.Ordinal));
		}
	}

	public class DoubleComparer : IComparer<double>
	{
		public int Compare (double x, double y)
		{
			if(x == y) return (0);
			if(x > y) return (1);
			else return(-1);
		}
	}
}

