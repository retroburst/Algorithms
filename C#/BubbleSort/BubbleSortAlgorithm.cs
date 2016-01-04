using System;
using System.Collections.Generic;

namespace BubbleSort
{
	public static class BubbleSortAlgorithm
	{
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

