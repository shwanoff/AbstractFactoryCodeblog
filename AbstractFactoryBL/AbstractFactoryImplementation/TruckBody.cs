namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Корпус Камаза.
	/// </summary>
	public class TruckBody : IBody
	{
		/// <summary>
		/// Аэродинамический коэффициент влияющий на скорость.
		/// </summary>
		public double Aerodynamic => 0.7;

		/// <summary>
		/// Максимальный вес.
		/// </summary>
		public double MaxWeight => 7900;

		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Корпус KAMAZ-5490";

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price => 1500000;

		/// <summary>
		/// Вес самого корпуса.
		/// </summary>
		public double Weight => 1000;
	}
}
