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

			Console.Out.WriteLine(string.Format("PerformQuickSort called with low={0} and high={1}.", low, high));

			int pivotIndex = low + (high - low) / 2;
			T pivot = target [pivotIndex];
			Console.Out.WriteLine(string.Format("Pivot at index={0}.", pivotIndex));

			while (i <= j) {
				// while elements on the left are less than the pivot element
				while (comparer.Compare (target [i], pivot) <= -1) {
					// move the pointer to the right
					i++;
				}
				// while elements on the right are more than the pivot element
				while (comparer.Compare (target [j], pivot) >= 1) {
					// move the pointer to the left
					j--;
				}
				if (i <= j) {
					if (i != j) {
						// swap the elements
						Console.Out.WriteLine(string.Format("Swapping at i={0} and j={1}.", i, j));
						T temp = target [i];
						target [i] = target [j];
						target [j] = temp;
					}
					// move the pointers after the swap
					i++;
					j--;
				}
			}
			if (j > low) {
				PerformQuickSort (target, comparer, low, j);
			}
			if (i < high) {
				PerformQuickSort (target, comparer, i, high);
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

