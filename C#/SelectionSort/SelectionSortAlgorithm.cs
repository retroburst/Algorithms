using System;
using System.Collections.Generic;

namespace SelectionSort
{
	/// <summary>
	/// Selection sort algorithm.
	/// </summary>
	public static class SelectionSortAlgorithm
	{
		/// <summary>
		/// Sorts the given list using the comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">Type of list elements.</typeparam>
		public static void SelectionSort<T> (IList<T> target, IComparer<T> comparer)
		{
			if (target == null)
				throw new ArgumentException ("Argument cannot be null.", "target");
			if (comparer == null)
				throw new ArgumentException ("Argument cannot be null.", "comparer");

			for(int i=0; i < target.Count; i++)
			{
				int minIndex = i;
				for(int j=i; j < target.Count; j++)
				{
					int compareResult = comparer.Compare(target[j], target[minIndex]);
					if(compareResult <= -1) 
					{
						minIndex = j;
					}
				}
				T temp = target[i];
				target[i] = target[minIndex];
				target[minIndex] = temp;
			}
		}

	}

	/// <summary>
	/// Selection sort algorithm list extensions.
	/// </summary>
	public static class SelectionSortAlgorithmListExtensions
	{
		/// <summary>
		/// Sorts list using Selection sort algorithm and given comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static void SelectionSort<T> (this IList<T> target, IComparer<T> comparer)
		{
			SelectionSortAlgorithm.SelectionSort(target, comparer);
		}
	}
}

