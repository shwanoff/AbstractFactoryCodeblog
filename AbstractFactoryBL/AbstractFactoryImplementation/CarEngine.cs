using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Двигатель легкового автомобиля Ока.
	/// </summary>
	public class CarEngine : IEngine
	{
		/// <summary>
		/// Максимально возможная скорость.
		/// </summary>
		public double MaxSpeed => 80;

		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Двигатель ВАЗ-1111";

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price => 50000;

		/// <summary>
		/// Вес двигателя.
		/// </summary>
		public double Weight => 250;

		/// <summary>
		/// Вычисление расхода топлива в зависимости от скорости.
		/// </summary>
		/// <param name="speed"> Скорость. </param>
		/// <returns> Расход топлива за 1 час. </returns>
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

			var fuel = 0.0008 * speed * speed - 0.2 * speed + 15;
			return fuel;
		}
	}
}
