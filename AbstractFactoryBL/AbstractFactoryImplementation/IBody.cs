namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Корпусы автомобилей.
	/// Определяет общие свойства и методы характерные для любого корпуса,
	/// не зависимо от того, к какому семейству он относится.
	/// </summary>
	public interface IBody : IComponent
	{
		double Aerodynamic { get; }
		double MaxWeight { get; }
	}
}
