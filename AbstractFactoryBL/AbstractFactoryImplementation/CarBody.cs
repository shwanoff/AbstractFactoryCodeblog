namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Корпус легкового автомобиля Ока.
	/// </summary>
	public class CarBody : IBody
	{
		/// <summary>
		/// Коэффициент аэродинамики влияющий на скорость.
		/// </summary>
		public double Aerodynamic => 1.1;

		/// <summary>
		/// Максимально возможный вес. 
		/// </summary>
		public double MaxWeight => 985;

		/// <summary>
		/// Наименование. 
		/// </summary>
		public string Name => "Корпус ВАЗ-1111";

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price => 30000;

		/// <summary>
		/// Вес корпуса.
		/// </summary>
		public double Weight => 350;
	}
}
