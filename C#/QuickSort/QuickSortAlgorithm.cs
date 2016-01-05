using System;
using System.Collections.Generic;

namespace QuickSort
{
	/// <summary>
	/// Quick sort algorithm.
	/// </summary>
	public static class QuickSortAlgorithm
	{
		/// <summary>
		/// Sorts the given list using the comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">Type of list elements.</typeparam>
		public static void QuickSort<T> (IList<T> target, IComparer<T> comparer)
		{
			if (target == null)
				throw new ArgumentException ("Argument cannot be null.", "target");
			if (comparer == null)
				throw new ArgumentException ("Argument cannot be null.", "comparer");
			
			PerformQuickSort (target, comparer, 0, target.Count - 1);
		}

		/// <summary>
		/// Performs the quick sort.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <param name="low">Low.</param>
		/// <param name="high">High.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		private static void PerformQuickSort<T> (IList<T> target, IComparer<T> comparer, int low, int high)
		{
			int i = low;
			int j = high;

			T pivot = target [low + (high - low) / 2];

			while (i <= j) {
				// while elements on the left are less than the pivot element
				while (comparer.Compare (target [i], pivot) <= -1) {
					i++;
				}
				// while elements on the right are more than the pivot element
				while (comparer.Compare (target [j], pivot) >= 1) {
					j--;
				}
				if (i <= j) {
					if (i != j) {
						T temp = target [i];
						target [i] = target [j];
						target [j] = temp;
					}
					i++;
					j--;
				}
				if (j > low) {
					PerformQuickSort (target, comparer, low, j);
				}
				if (i < high) {
					PerformQuickSort (target, comparer, i, high);
				}
			}
		}

	}

	/// <summary>
	/// Quick sort algorithm list extensions.
	/// </summary>
	public static class QuickSortAlgorithmListExtensions
	{
		/// <summary>
		/// Sorts list using Quick sort algorithm and given comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static void QuickSort<T> (this IList<T> target, IComparer<T> comparer)
		{
			QuickSortAlgorithm.QuickSort (target, comparer);
		}
	}
}

