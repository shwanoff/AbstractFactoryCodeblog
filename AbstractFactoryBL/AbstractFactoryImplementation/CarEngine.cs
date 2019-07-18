using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class CarEngine : IEngine
	{
		public double MaxSpeed => 80;

		public string Name => "Двигатель ВАЗ-1111";

		public decimal Price => 50000;

		public double Weight => 250;

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
