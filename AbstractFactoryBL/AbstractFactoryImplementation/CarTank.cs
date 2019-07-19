namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	/// <summary>
	/// Топливный бак легкового автомобиля Ока.
	/// </summary>
	public class CarTank : ITank
	{
		/// <summary>
		/// Максимальный объем бака.
		/// </summary>
		public double MaxVolume => 30;

		/// <summary>
		/// Текущий объем бака.
		/// </summary>
		public double Volume { get; private set; }

		/// <summary>
		/// Флаг, указывающий является ли бак пустым.
		/// </summary>
		public bool Empty => Volume == 0;

		/// <summary>
		/// Множитель пустоты бака, влияющий на скорость.
		/// Чем меньше топлива, тем меньше вес, тем выше скорость.
		/// </summary>
		public double SpeedFactor
		{
			get
			{
				var currentVolumePercent = Volume / MaxVolume;
				return -0.4 * currentVolumePercent + 1.2;
			}
		}

		/// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Бак ВАЗ-1111";

		/// <summary>
		/// Стоимость бака.
		/// </summary>
		public decimal Price => 20000;

		/// <summary>
		/// Вес бака с учетом топлива в нем.
		/// </summary>
		public double Weight => 45 + Volume;

		/// <summary>
		/// Создать бак легкового автомобиля.
		/// </summary>
		public CarTank()
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
