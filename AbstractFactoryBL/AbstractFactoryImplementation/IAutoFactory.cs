namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Абстрактная фабрика по производству автомобилей.
	/// </summary>
	public interface IAutoFactory
	{
		IBody CreateBody();
		IEngine CreateEngine();
		ITank CreateTank();
	}
}
