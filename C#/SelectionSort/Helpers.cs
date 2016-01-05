using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
	/// <summary>
	/// Helpers.
	/// </summary>
	public static class Helpers
	{
		private static Random random = new Random();

		/// <summary>
		/// Generates a random integer array.
		/// </summary>
		/// <returns>The random integer array.</returns>
		/// <param name="size">Size.</param>
		/// <param name="min">Minimum.</param>
		/// <param name="max">Max.</param>
		public static int[] GenerateRandomIntegerArray(int size, int min, int max)
		{
			int[] result = new int[size];
			for(int i=0; i < size; i++)
			{
				result[i] = random.Next(min, max);
			}
			return(result);
		}

		/// <summary>
		/// Generates a random double array.
		/// </summary>
		/// <returns>The random double array.</returns>
		/// <param name="size">Size.</param>
		public static double[] GenerateRandomDoubleArray(int size)
		{
			double[] result = new double[size];
			for(int i=0; i < size; i++)
			{
				result[i] = Math.Round(random.NextDouble() * 100, 2);
			}
			return(result);
		}

		/// <summary>
		/// Textualizes a list.
		/// </summary>
		/// <returns>The list.</returns>
		/// <param name="target">Target.</param>
		/// <param name="elementFormat">Element format.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		public static string TextualizeList<T>(IList<T> target, string elementFormat = "{0}")
		{
			if(string.IsNullOrEmpty(elementFormat)) elementFormat = "{0}";
			StringBuilder result = new StringBuilder();
			result.Append("[");
			for(int i=0; i < target.Count; i++)
			{
				result.AppendFormat(elementFormat, target[i]);
				if(i < (target.Count - 1)) result.Append(", ");
			}
			result.Append("]");
			return(result.ToString());
		} 
	}
}

