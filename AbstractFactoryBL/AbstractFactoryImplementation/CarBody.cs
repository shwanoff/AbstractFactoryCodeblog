namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class CarBody : IBody
	{
		public double Aerodynamic => 1.1;

		public double MaxWeight => 985;

		public string Name => "Корпус ВАЗ-1111";

		public decimal Price => 30000;

		public double Weight => 350;
	}
}
