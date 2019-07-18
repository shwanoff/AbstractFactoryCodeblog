namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Первый абстрактный продукт.
	/// Определяет общее поведение для всех первых продуктов.
	/// </summary>
	public interface IAbstractProductA
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Работа, выполняемая первым продуктом.
		/// </summary>
		/// <returns> Результат работы. </returns>
		string DoWorkA();
	}
}
