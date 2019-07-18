namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Абстрактная фабрика.
	/// Здесь мы просто объявляем фабричные методы для каждого из продуктов,
	/// не конкретизируя, какой именно это будет продукт. Только его интерфейс.
	/// </summary>
	public interface IAbstractFactory
	{
		/// <summary>
		/// Фабричный метод для первого продукта.
		/// </summary>
		/// <returns> Первый продукт. </returns>
		IAbstractProductA CreateProductA();

		/// <summary>
		/// Фабричный метод для второго продукта.
		/// </summary>
		/// <returns> Второй продукт. </returns>
		IAbstractProductB CreateProductB();
	}
}
