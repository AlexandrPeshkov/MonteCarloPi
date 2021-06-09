using System;

namespace RandomPi
{
	/// <summary>
	/// Генератор случайных точек
	/// </summary>
	internal static class PointGenerator
	{
		private static readonly Random random = new Random();

		/// <summary>
		/// Получить случайную точку на плоскости с координатами:
		/// X = [0, 1)
		/// Y = [0, 1)
		/// </summary>
		/// <returns> </returns>
		public static Point2 Generate()
		{
			return new Point2(
				random.NextDouble(),
				random.NextDouble());
		}
	}
}
