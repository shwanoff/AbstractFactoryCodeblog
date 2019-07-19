namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Топливный бак Камаза.
	/// </summary>
	public class TruckTank : ITank
	{
		/// <summary>
		/// Максимально возможный объем топлива.
		/// </summary>
		public double MaxVolume => 800;

		/// <summary>
		/// Текущий объем топлива.
		/// </summary>
		public double Volume { get; private set; }

		/// <summary>
		/// Является ли бак пустым.
		/// </summary>
		public bool Empty => Volume == 0;

		/// <summary>
		/// Множитель скорости в зависимости от заполненности бака.
		/// </summary>
		public double SpeedFactor
		{
			get
			{
				var currentVolumePercent = Volume / MaxVolume;
				return -0.15 * currentVolumePercent + 1.1;
			}
		}

		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Бак KAMAZ-5490";

		/// <summary>
		/// Стоимость.
		/// </summary>
		public decimal Price => 300000;

		/// <summary>
		/// Вес бака.
		/// </summary>
		public double Weight => 200 + Volume;

		/// <summary>
		/// Создать бак грузовика.
		/// </summary>
		public TruckTank()
		{
			Volume = MaxVolume;
		}

		/// <summary>
		/// Израсходовать часть топлива из бака для движения.
		/// </summary>
		/// <param name="fuel"> Необходимое количество топлива. </param>
		/// <returns> 
		/// Множитель, указывающий сколько топлива фактически было использовано.
		/// Значение на отрезке [0; 1], где 0 - топлива нет, 1 - имеется все необходимое топливо.
		/// Значение влияет на фактически пройденный путь.
		/// Если был запрос на 10 литров топлива, а в баке было только 3, 
		/// то будет возвращено значение 0.3, указывающее что пройдена треть пусти.
		/// </returns>
		public double Spend(double fuel)
		{
			if(fuel <= Volume)
			{
				Volume -= fuel;
				return 1;
			}
			else
			{
				var wayPercent = Volume / fuel;
				Volume = 0;
				return wayPercent;
			}
		}
	}
}
