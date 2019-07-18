using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public abstract class AutoBase : IAuto
	{
		public IBody Body { get; protected set; }

		public IEngine Engine { get; protected set; }

		public ITank Tank { get; protected set; }

		public string Vin { get; }

		public decimal Price
		{
			get
			{
				if(Body != null && Engine != null && Tank != null)
				{
					return (Body.Price + Engine.Price + Tank.Price) * 1.5M;
				}
				else
				{
					return 0;
				}
			}
		}

		public double Weight
		{
			get
			{
				if(Body != null && Engine != null && Tank != null)
				{
					return Body.Weight + Engine.Weight + Tank.Weight;

				}
				else
				{
					return 0;
				}
			}
		}

		public event EventHandler<double> Moved;

		public AutoBase(IAutoFactory factory)
		{
			Body = factory.CreateBody();
			Engine = factory.CreateEngine();
			Tank = factory.CreateTank();

			Vin = Guid.NewGuid().ToString();
		}

		public double Start(double speed)
		{
			if(Weight > Body.MaxWeight)
			{
				throw new Exception("Вес автомобиля больше максимального. Движение не возможно.");
			}

			var path = 0.0;
			while(!Tank.Empty) // Продолжаем движение пока бак не пустой.
			{
				path += Step(speed); // Находимся в движении отрезок времени (один час).
				Moved?.Invoke(this, path); // Сообщаем о перемещении автомобиля.
			}

			return path;
		}

		private double Step(double speed)
		{
			// Определяем фактическую скорость. 
			var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
			actualSpeed *= Body.Aerodynamic;
			actualSpeed *= Tank.SpeedFactor;

			// Вычисляем количество потребляемого горючего.
			var needFuel = Engine.GetConsumption(actualSpeed);

			// Вычисляем, какую часть пути может пройти автомобиль.
			// Это сделано так, если расход топлива 10 литров на 100 км, 
			// а в баке сталось 5 литров. Тогда автомобиль пройдет половину пути.
			var pathRate = Tank.Spend(needFuel);
			var path = actualSpeed * pathRate;
			return path;
		}
	}
}
