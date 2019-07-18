namespace AbstractFactoryBL.BaseImplementation
{
	/// <summary>
	/// Двигатель автомобиля.
	/// </summary>
	public class Engine
	{
		/// <summary>
		/// Название.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Максимальная возможная скорость.
		/// </summary>
		public double MaxSpeed { get; }

		/// <summary>
		/// Стоимость. 
		/// </summary>
		public decimal Price { get; }

		/// <summary>
		/// Вес.
		/// </summary>
		public double Weight { get; }

		/// <summary>
		/// Создать двигатель.
		/// </summary>
		/// <param name="name"> Название. </param>
		/// <param name="maxSpeed"> Максимальная скорость. </param>
		/// <param name="price"> Стоимость. </param>
		/// <param name="weight"> Вес. </param>
		public Engine(string name, double maxSpeed, decimal price, double weight)
		{
			// TODO: Выполнить проверку входных аргументов.
			Name = name;
			MaxSpeed = maxSpeed;
			Price = price;
			Weight = weight;
		}

		/// <summary>
		/// Вычисляем потребление топлива на 100 км, в зависимости от скорости.
		/// </summary>
		/// <param name="speed"> Скорость (км/ч). </param>
		/// <returns> Расход топлива (литров на 100 км). </returns>
		public double GetConsumption(double speed)
		{
			var actulaSpeed = speed > 0 ? speed : 1;

			// Формула подбиралась по определенным значениям,
			// чтобы быть приблизительна похожа на правду.
			var fuel = 0.0008 * actulaSpeed * actulaSpeed - 0.2 * actulaSpeed + 17;
			return fuel;
		}

		/// <summary>
		/// Приведение объекта к строке.
		/// </summary>
		/// <returns> Название. </returns>
		public override string ToString()
		{
			return Name;
		}
	}
}
