namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Второй конкретный продукт второго вида.
	/// Выпускается второй конкретной фабрикой.
	/// </summary>
	public class ConcreteProductB2 : IAbstractProductB
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "B2";

		/// <summary>
		/// Какие-либо действия, которые может выполнять продукт B.
		/// </summary>
		/// <returns> Результаты работы. </returns>
		public string DoWorkB()
		{
			return "B2 выполнил свою работу.";
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
			return $"B2 выполнил работу совместно с ({productA.Name})";
		}
	}
}
