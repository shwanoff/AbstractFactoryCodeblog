using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class Car : AutoBase
	{
		public Car() : base(new CarFactory())
		{
		}
	}
}
