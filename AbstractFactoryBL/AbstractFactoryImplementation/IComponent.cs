namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public interface IComponent
	{
		string Name { get; }
		decimal Price { get; }
		double Weight { get; }
	}
}
