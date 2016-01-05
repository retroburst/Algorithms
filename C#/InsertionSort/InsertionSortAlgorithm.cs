using System;
using System.Collections.Generic;

namespace InsertionSort
{
	/// <summary>
	/// Insertion sort algorithm.
	/// </summary>
	public static class InsertionSortAlgorithm
	{
		/// <summary>
		/// Sorts the given list using the comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">Type of list elements.</typeparam>
		public static void InsertionSort<T> (IList<T> target, IComparer<T> comparer)
		{
			if (target == null)
				throw new ArgumentException ("Argument cannot be null.", "target");
			if (comparer == null)
				throw new ArgumentException ("Argument cannot be null.", "comparer");

			Func<T, T, bool> isLessThanFunc = (x,y) => (comparer.Compare(x, y) <= -1);
			
			for(int i=1; i < target.Count; i++)
			{
				T targetElement = target[i];
				int j = 0;
				for(j = i - 1; j >= 0 && isLessThanFunc(targetElement, target[j]); j--)
				{
					target[j + 1] = target[j];
				}
				target[j + 1] = targetElement;
			}
		}

	}

	/// <summary>
	/// Insertion sort algorithm list extensions.
	/// </summary>
	public static class InsertionSortAlgorithmListExtensions
	{
		/// <summary>
		/// Sorts list using Insertion sort algorithm and given comparer.
		/// </summary>
		/// <param name="target">Target.</param>
		/// <param name="comparer">Comparer.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static void InsertionSort<T> (this IList<T> target, IComparer<T> comparer)
		{
			InsertionSortAlgorithm.InsertionSort(target, comparer);
		}
	}
}

