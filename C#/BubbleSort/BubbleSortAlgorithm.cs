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
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">Type of list elements.</typeparam>
		public static void BubbleSort<T> (IList<T> target, IComparer<T> comparer)
		{
			if (target == null)
				throw new ArgumentException ("Argument cannot be null.", "target");
			if (comparer == null)
				throw new ArgumentException ("Argument cannot be null.", "comparer");

			bool swapping = false;
			do {
				swapping = false;
				for (int i = 0; i < target.Count - 1; i++) {
					int compareResult = comparer.Compare (target [i], target [i + 1]);
					if (compareResult >= 1) {
						T temp = target [i + 1];
						target [i + 1] = target [i];
						target [i] = temp;
						swapping = true;
					}
				}
			} while (swapping);
		}

	}

	/// <summary>
	/// Bubble sort algorithm list extensions.
	/// </summary>
	public static class BubbleSortAlgorithmListExtensions
	{
		/// <summary>
		/// Sorts list using bubble sort algorithm and given comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static void BubbleSort<T> (this IList<T> target, IComparer<T> comparer)
		{
			BubbleSortAlgorithm.BubbleSort(target, comparer);
		}
	}
}

