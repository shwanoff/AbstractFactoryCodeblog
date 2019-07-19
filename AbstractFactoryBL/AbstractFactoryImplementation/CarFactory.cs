namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Фабрика для легкового автомобиля Ока.
	/// Определяет семейство компонентов для легкового автомобиля.
	/// Содержит в себе фабричные методы.
	/// </summary>
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
