using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class TruckEngine : IEngine
	{
		public double MaxSpeed => 110;

		public string Name => "Daimler OM 457LA";

		public decimal Price => 2000000;

		public double Weight => 1500;

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
