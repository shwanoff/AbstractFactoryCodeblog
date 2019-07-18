namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Первый конкретный продукт первого вида.
	/// Выпускается первой конкретной фабрикой.
	/// </summary>
	public class ConcreteProductA1 : IAbstractProductA
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "A1";

		/// <summary>
		/// Какие-либо действия, которые может выполнять продукт A.
		/// </summary>
		/// <returns> Результаты работы. </returns>
		public string DoWorkA()
		{
			return "A1 выполнил свою работу.";
		}
	}
}
