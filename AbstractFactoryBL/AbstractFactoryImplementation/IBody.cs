namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public interface IBody : IComponent
	{
		double Aerodynamic { get; }
		double MaxWeight { get; }
	}
}
