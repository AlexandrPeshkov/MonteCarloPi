using System;
using System.Diagnostics;

namespace RandomPi
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			do
			{
				Console.Write("Step count: ");
				if (int.TryParse(Console.ReadLine(), out var steps))
				{
					var stopwatch = new Stopwatch();
					stopwatch.Start();

					var pi = PiProcessing.CalcPi(steps);

					stopwatch.Stop();
					Console.WriteLine($"Result {pi}");
					Console.WriteLine($"Accuracy {Math.Abs(Math.Min(Math.PI, pi) / Math.Max(Math.PI, pi)):P}");
					Console.WriteLine($"Time {stopwatch.Elapsed}");
				}
			} while (true);
		}
	}
}
