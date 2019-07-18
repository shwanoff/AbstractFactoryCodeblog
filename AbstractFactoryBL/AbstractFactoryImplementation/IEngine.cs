namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public interface IEngine : IComponent
	{
		double MaxSpeed { get; }

		double GetConsumption(double speed);
	}
}
