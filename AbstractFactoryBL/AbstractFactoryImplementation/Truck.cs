namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class Truck : AutoBase
	{
		public Truck() : base(new TruckFactory())
		{
		}
	}
}
