using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
	public static class Helpers
	{
		public static int[] GenerateRandomIntegerArray(int size, int min, int max, Random random)
		{
			int[] result = new int[size];
			for(int i=0; i < size; i++)
			{
				result[i] = random.Next(min, max);
			}
			return(result);
		}

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

