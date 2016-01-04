using System;

namespace BubbleSort
{
	/// <summary>
	/// Program.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			Random random = new Random();
			string text = "And I see it too. Mountains dressed in summer green, humid and thriving in the heat, standing proud in a long line and stretching into the spotless sky.";
			string[] words = text.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[] integers = Helpers.GenerateRandomIntegerArray(20, 0, 100, random);

			Console.Out.Write(string.Format("Integers before bubble sorting: {0}", Helpers.TextualizeList(integers, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);
			BubbleSortAlgorithm.BubbleSort(integers, new IntegerComparer());
			Console.Out.Write(string.Format("Integers after bubble sorting: {0}", Helpers.TextualizeList(integers, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);

			Console.Out.Write(string.Format("Words before bubble sorting: {0}", Helpers.TextualizeList(words, "\"{0}\"")));
			Console.Out.WriteLine(Environment.NewLine);
			BubbleSortAlgorithm.BubbleSort(words, new StringOrdinalComparer());
			Console.Out.Write(string.Format("Words after bubble sorting: {0}", Helpers.TextualizeList(words, "\"{0}\"")));
			Console.Out.WriteLine();
		}
	}
}
