using System;

namespace InsertionSort
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
			string text = "And I see it too. Mountains dressed in summer green, humid and thriving in the heat, standing proud in a long line and stretching into the spotless sky.";
			string[] words = text.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int[] integers = Helpers.GenerateRandomIntegerArray(20, 0, 100);
			double[] doubles = Helpers.GenerateRandomDoubleArray(20);

			Console.Out.Write(string.Format("Integers before Insertion sorting: {0}", Helpers.TextualizeList(integers, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);
			integers.InsertionSort(new IntegerComparer());
			Console.Out.Write(string.Format("Integers after Insertion sorting: {0}", Helpers.TextualizeList(integers, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);

			Console.Out.Write(string.Format("Words before Insertion sorting: {0}", Helpers.TextualizeList(words, "\"{0}\"")));
			Console.Out.WriteLine(Environment.NewLine);
			words.InsertionSort(new StringOrdinalComparer());
			Console.Out.Write(string.Format("Words after Insertion sorting: {0}", Helpers.TextualizeList(words, "\"{0}\"")));
			Console.Out.WriteLine(Environment.NewLine);

			Console.Out.Write(string.Format("Doubles before Insertion sorting: {0}", Helpers.TextualizeList(doubles, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);
			doubles.InsertionSort(new DoubleComparer());
			Console.Out.Write(string.Format("Doubles after Insertion sorting: {0}", Helpers.TextualizeList(doubles, "{0}")));
			Console.Out.WriteLine(Environment.NewLine);
		}
	}
}
