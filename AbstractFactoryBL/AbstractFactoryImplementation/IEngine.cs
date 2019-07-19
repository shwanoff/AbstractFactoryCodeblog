namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Двигатели автомобилей.
	/// Определяет общие свойства и методы характерные для любого двигателя,
	/// не зависимо от того, к какому семейству он относится.
	/// </summary>
	public interface IEngine : IComponent
	{
		double MaxSpeed { get; }

		double GetConsumption(double speed);
	}
}
