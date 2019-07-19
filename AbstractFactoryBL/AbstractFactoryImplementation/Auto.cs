using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Транспортное средство.
	/// Здесь определены основные компоненты из которых состоит любой автомобиль и
	/// реализовано их взаимодействие.
	/// При этом используются не конкретные реализации, а базовые интерфейсы,
	/// что позволяет динамически конфигурировать составные компоненты автомобиля.
	/// Конфигурация выполняется передачей в конструктор фабрики.
	/// Важно понимать, что этот класс по сути уже является клиентом абстрактной фабрики.
	/// Абстрактная фабрика не обязана возвращать один объект. Она возвращает отдельные компоненты,
	/// которые могут как собираться в единое целое (как здесь), 
	/// так и просто взаимодействовать между собой.
	/// Но абстрактная фабрика гарантирует, что эти компоненты будут 
	/// корректно совместимым и правильно взаимодействовать друг с другом.
	/// </summary>
	public class Auto
	{
		/// <summary>
		/// Корпус автомобиля.
		/// </summary>
		public IBody Body { get; }

		/// <summary>
		/// Двигатель автомобиля.
		/// </summary>
		public IEngine Engine { get; }

		/// <summary>
		/// Топливный бак автомобиля.
		/// </summary>
		public ITank Tank { get; }

		/// <summary>
		/// Уникальный номер.
		/// </summary>
		public string Vin { get; }

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price
		{
			get
			{
				if(Body != null && Engine != null && Tank != null)
				{
					var markup = 1.5M; // Наценка.
					return (Body.Price + Engine.Price + Tank.Price) * markup;
				}
				else
				{
					return 0;
				}
			}
		}

		/// <summary>
		/// Вес.
		/// </summary>
		public double Weight
		{
			get
			{
				if(Body != null && Engine != null && Tank != null)
				{
					var weight = Body.Weight + Engine.Weight + Tank.Weight;
					if(weight <= Body.MaxWeight)
					{
						return weight;
					}
					else
					{
						throw new Exception("Вес автомобиля превысил максимально возможный.");
					}
				}
				else
				{
					return 0;
				}
			}
		}

		/// <summary>
		/// Автомобиль переместился.
		/// Возвращает пройденный путь.
		/// </summary>
		public event EventHandler<double> Moved;

		/// <summary>
		/// Создать новый автомобиль.
		/// </summary>
		/// <param name="factory"> Фабрика, определяющая, какой это автомобиль будет. </param>
		public Auto(IAutoFactory factory)
		{
			Body = factory.CreateBody();
			Engine = factory.CreateEngine();
			Tank = factory.CreateTank();

			Vin = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// Начать движение автомобиля.
		/// </summary>
		/// <param name="speed"> Скорость. </param>
		/// <returns> Пройденный путь. </returns>
		public double Start(double speed)
		{
			if(Weight > Body.MaxWeight)
			{
				throw new Exception("Вес автомобиля больше максимального. Движение не возможно.");
			}

			var path = 0.0;
			while(!Tank.Empty)
			{
				path += Step(speed); 
				Moved?.Invoke(this, path);
			}

			return path;
		}

		/// <summary>
		/// Перемещение автомобиля в течение часа.
		/// </summary>
		/// <param name="speed"> Скорость. </param>
		/// <returns> Пройденное расстояние за час. </returns>
		protected double Step(double speed)
		{
			var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
			actualSpeed *= Body.Aerodynamic;
			actualSpeed *= Tank.SpeedFactor;
			var needFuel = Engine.GetConsumption(actualSpeed);
			var pathRate = Tank.Spend(needFuel);
			var path = actualSpeed * pathRate;
			return path;
		}
	}
}
