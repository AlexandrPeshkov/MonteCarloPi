using System;
using System.Runtime.CompilerServices;

namespace RandomPi
{
	/// <summary>
	/// Вычисление числа Пи методом Монте-Карло
	/// </summary>
	public static class PiProcessing
	{
		/// <summary>
		/// </summary>
		private static readonly Point2 _circleCenter = new Point2(0.5, 0.5);

		private const double _circleRadius = 0.5;

		private const double _circleRadiusSqr = _circleRadius * _circleRadius;

		/// <summary>
		/// Приближенное вычисление PI методом Монте-Карло
		/// </summary>
		/// <param name="stepCount"> </param>
		/// <returns> </returns>
		public static double CalcPi(int stepCount)
		{
			double circleSquare = 0;
			double rectSquare = stepCount;

			for (var i = 0; i < stepCount; i++)
			{
				var point = PointGenerator.Generate();
				if (PointInCircle(point))
				{
					circleSquare++;
				}
			}

			return 4 * circleSquare / rectSquare;
		}

		/// <summary>
		/// Проверка нахождения точки в окружности
		/// </summary>
		/// <param name="point"> </param>
		/// <returns> </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool PointInCircle(Point2 point)
		{
			return Math.Pow(point.Y - _circleCenter.Y, 2) + Math.Pow(point.X - _circleCenter.X, 2) <= _circleRadiusSqr;
		}
	}
}
