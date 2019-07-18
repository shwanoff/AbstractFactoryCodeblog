namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public class CarTank : ITank
	{
		public double MaxVolume => 30;

		public double Volume { get; private set; }

		public bool Empty => Volume == 0;

		public double SpeedFactor
		{
			get
			{
				var currentVolumePercent = Volume / MaxVolume;
				return -0.4 * currentVolumePercent + 1.2;
			}
		}

		public string Name => "Бак ВАЗ-1111";

		public decimal Price => 20000;

		public double Weight => 45 + Volume;

		public double Spend(double fuel)
		{
			if(fuel <= Volume)
			{
				// Если в баке больше топлива чем нужно, просто расходуем этот объем
				// и возвращаем 1 (= 100%)
				Volume -= fuel;
				return 1;
			}
			else
			{
				// Если в баке меньше, чем нужно, то расходуем все что есть,
				// и возвращаем процент от желаемого.
				var wayPercent = Volume / fuel;
				Volume = 0;
				return wayPercent;
			}
		}
	}
}
