namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Второй конкретный продукт первого вида.
	/// Выпускается первой конкретной фабрикой.
	/// </summary>
	public class ConcreteProductB1 : IAbstractProductB
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "B1";

		/// <summary>
		/// Какие-либо действия, которые может выполнять продукт B.
		/// </summary>
		/// <returns> Результаты работы. </returns>
		public string DoWorkB()
		{
			return "B1 выполнил свою работу.";
		}

		/// <summary>
		/// Совместная работа различных продуктов.
		/// Продукты вполне могут между собой взаимодействовать.
		/// При этом фабрика будет гарантировать, что эти продукты будут совместимы,
		/// не смотря на то, что в объявлении указывается абстрактный продукт.
		/// </summary>
		/// <param name="productA"> Первый продукт. </param>
		/// <returns> Результат взаимодействия первого и второго продукта. </returns>
		public string WorkWithProductA(IAbstractProductA productA)
		{
			return $"B1 выполнил работу совместно с ({productA.Name})";
		}
	}
}
