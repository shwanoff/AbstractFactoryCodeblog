namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Второй абстрактный продукт.
	/// Определяет общее поведение для всех вторых продуктов.
	/// </summary>
	public interface IAbstractProductB
	{
		/// <summary>
		/// Наименование. 
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Работа, выполняемая вторым продуктом.
		/// </summary>
		/// <returns> Результаты работы. </returns>
		string DoWorkB();

		/// <summary>
		/// Взаимодействие первого и второго продукта.
		/// (если оно нужно)
		/// </summary>
		/// <param name="productA"> Первый продукт. </param>
		/// <returns> Результат взаимодействия. </returns>
		string WorkWithProductA(IAbstractProductA productA);
	}
}
