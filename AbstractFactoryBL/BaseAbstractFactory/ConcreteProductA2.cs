namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Первый конкретный продукт второго вида.
	/// Выпускается второй конкретной фабрикой.
	/// </summary>
	public class ConcreteProductA2 : IAbstractProductA
	{
		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "A2";

		/// <summary>
		/// Какие-либо действия, которые может выполнять продукт A.
		/// </summary>
		/// <returns> Результаты работы. </returns>
		public string DoWorkA()
		{
			return "A2 выполнил свою работу.";
		}
	}
}
