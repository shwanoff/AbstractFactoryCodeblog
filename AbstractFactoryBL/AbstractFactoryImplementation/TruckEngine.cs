using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Двигатель Камаза.
	/// </summary>
	public class TruckEngine : IEngine
	{
		/// <summary>
		/// Максимально возможная скорость.
		/// </summary>
		public double MaxSpeed => 110;

		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Daimler OM 457LA";

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price => 2000000;

		/// <summary>
		/// Вес.
		/// </summary>
		public double Weight => 1500;

		/// <summary>
		/// Вычислить расход топлива в час по скорости.
		/// </summary>
		/// <param name="speed"> Скорость движения. </param>
		/// <returns> Количество потребляемых литров топлива за час. </returns>
		public double GetConsumption(double speed)
		{
			if(speed < 0)
			{
				throw new ArgumentException("Скорость не может быть меньше нуля.", nameof(speed));
			}

			if(speed == 0)
			{
				return 0;
			}

			var fuel = 0.005 * speed * speed - 0.8 * speed + 60;
			return fuel;
		}
	}
}
