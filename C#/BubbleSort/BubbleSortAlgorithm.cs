using System;
using System.Collections.Generic;

namespace BubbleSort
{
	/// <summary>
	/// Bubble sort algorithm.
	/// </summary>
	public static class BubbleSortAlgorithm
	{
		/// <summary>
		/// Sorts the given list using the comparer.
		/// </summary>
		/// <returns>The sort.</returns>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">Type of list elements.</typeparam>
		public static IList<T> BubbleSort<T>(IList<T> target, IComparer<T> comparer)
		{
			if(target == null) throw new ArgumentException("Argument cannot be null.", "target");
			if(comparer == null) throw new ArgumentException("Argument cannot be null.", "comparer");

			for(int i=0; i < target.Count; i++)
			{
				for(int j=0; j < target.Count-1; j++)
				{
					int compareResult = comparer.Compare(target[j], target[j+1]);
					if(compareResult >= 1)
					{
						T temp = target[j+1];
						target[j+1] = target[j];
						target[j] = temp;
					}
				}
			}
			return(target);
		}
	}
}

