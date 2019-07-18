using System;

namespace AbstractFactoryBL.BaseImplementation
{
	/// <summary>
	/// Автомобиль.
	/// </summary>
	public class Car
	{
		/// <summary>
		/// Корпус.
		/// </summary>
		public Body Body { get; }

		/// <summary>
		/// Двигатель.
		/// </summary>
		public Engine Engine { get; }

		/// <summary>
		/// Топливный бак.
		/// </summary>
		public Tank Tank { get; }

		/// <summary>
		/// Уникальный номер двигателя.
		/// </summary>
		public string Vin { get; }

		/// <summary>
		/// Себестоимость всего автомобиля.
		/// </summary>
		public decimal Price { get; }

		/// <summary>
		/// Вес всего автомобиля.
		/// </summary>
		public double Weight
		{
			get
			{
				return Body.Weight + Engine.Weight + Tank.Weight;
			}
		}

		/// <summary>
		/// Событие перемещения автомобиля за 1 час. 
		/// Возвращает пройденное расстояние.
		/// </summary>
		public event EventHandler<double> Moved;
		

		/// <summary>
		/// Создать новый автомобиль.
		/// </summary>
		/// <param name="body"> Корпус. </param>
		/// <param name="engine"> Двигатель. </param>
		/// <param name="tank"> Бак. </param>
		public Car(Body body, Engine engine, Tank tank)
		{
			// TODO: Проверка входных аргументов.

			Body = body;
			Engine = engine;
			Tank = tank;
			Price = (Body.Price + Engine.Price + Tank.Price) * 1.5M;
			
			Vin = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// Начать движение автомобиля.
		/// </summary>
		/// <param name="speed"> Скорость передвижения. </param>
		/// <returns> Пройденное расстояние. </returns>
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

		/// <summary>
		/// Передвижение автомобиля на один шаг.
		/// Шаг задается скоростью. Если скорость в км/ч, то шаг - 1 час.
		/// </summary>
		/// <param name="speed"> Скорость движения. </param>
		/// <returns> Пройденное расстояние за шаг. </returns>
		private double Step(double speed)
		{
			// Определеяем фактическую скорость. 
			var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
			actualSpeed *= Body.Aerodynamic;
			actualSpeed *= Tank.SpeedFactor;

			// Вычисляем количество потребляемого горючего.
			var needFuel = Engine.GetConsumption(actualSpeed);

			// Вычисляем, какую часть пути может пройти автомобиль.
			// Это сделано так, если расход топлива 10 литров на 100 км, 
			// а в баке осталоь 5 литров. Тогда автомобиль пройдлет половину пути.
			var pathRate = Tank.Spend(needFuel);
			var path = actualSpeed * pathRate;
			return path;
		}

		/// <summary>
		/// Приведение обекта к строке.
		/// </summary>
		/// <returns> Уникальный нормер. </returns>
		public override string ToString()
		{
			return Vin;
		}
	}
}
