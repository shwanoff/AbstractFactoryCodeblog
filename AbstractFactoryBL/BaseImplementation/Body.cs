namespace AbstractFactoryBL.BaseImplementation
{
	/// <summary>
	/// Корпус автомобиля.
	/// </summary>
	public class Body
	{
		/// <summary>
		/// Название.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Коэффициент аэродинамики.
		/// </summary>
		public double Aerodynamic { get; }

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price { get; }

		/// <summary>
		/// Максимальный общий вес, который может выдержать корпус.
		/// </summary>
		public double MaxWeight { get; }

		/// <summary>
		/// Вес самого корпуса.
		/// </summary>
		public double Weight { get; }

		/// <summary>
		/// Создать новый корпус автомобиля.
		/// </summary>
		/// <param name="name"> Название. </param>
		/// <param name="aerodynamic"> Коэффициент аэродинамики. </param>
		/// <param name="price"> Стоимость. </param>
		/// <param name="maxWeight"> Максимальный вес. </param>
		/// <param name="weight"> Вес. </param>
		public Body(string name, double aerodynamic, decimal price, double maxWeight, double weight)
		{
			// TODO: проверка входных аргументов.

			Name = name;
			Aerodynamic = aerodynamic;
			Price = price;
			MaxWeight = maxWeight;
			Weight = weight;
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
