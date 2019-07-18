using System;

namespace AbstractFactoryBL.BaseAbstractFactory
{
	/// <summary>
	/// Класс, который эмулирует работу клиентского кода с абстрактной фабрикой.
	/// </summary>
	public class Client
	{
		/// <summary>
		/// Создать продукты двух видов.
		/// </summary>
		public void DoWork()
		{
			CreateProducts(new ConcreteFactory1());
			CreateProducts(new ConcreteFactory2());
		}

		/// <summary>
		/// Метод выполняет производство различных продуктов в зависимости от используемой фабрики.
		/// </summary>
		/// <param name="factory"> Фабрика. </param>
		private void CreateProducts(IAbstractFactory factory)
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();

			Console.WriteLine(productB.DoWorkB());
			Console.WriteLine(productB.WorkWithProductA(productA));
		}
	}
}
