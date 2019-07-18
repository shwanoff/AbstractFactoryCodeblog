namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public interface IAutoFactory
	{
		IBody CreateBody();
		IEngine CreateEngine();
		ITank CreateTank();
	}
}
