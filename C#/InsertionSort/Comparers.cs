using System;
using System.Collections.Generic;

namespace InsertionSort
{
	/// <summary>
	/// Integer comparer.
	/// </summary>
	public class IntegerComparer : IComparer<int>
	{
		/// <summary>
		/// Compare the specified x and y.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public int Compare (int x, int y)
		{
			if(x == y) return (0);
			if(x > y) return (1);
			else return(-1);
		}
	}

	/// <summary>
	/// String ordinal comparer.
	/// </summary>
	public class StringOrdinalComparer : IComparer<string>
	{
		/// <summary>
		/// Compare the specified x and y.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public int Compare (string x, string y)
		{
			return(string.Compare(x, y, StringComparison.OrdinalIgnoreCase));
		}
	}

	/// <summary>
	/// Double comparer.
	/// </summary>
	public class DoubleComparer : IComparer<double>
	{
		/// <summary>
		/// Compare the specified x and y.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		public int Compare (double x, double y)
		{
			if(x == y) return (0);
			if(x > y) return (1);
			else return(-1);
		}
	}
}

