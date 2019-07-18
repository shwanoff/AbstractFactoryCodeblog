namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class CarFactory : IAutoFactory
	{
		public IBody CreateBody()
		{
			return new CarBody();
		}

		public IEngine CreateEngine()
		{
			return new CarEngine();
		}

		public ITank CreateTank()
		{
			return new CarTank();
		}
	}
}
