namespace AbstractFactoryBL.BaseImplementation
{
    public class Tank
    {
        public string Name { get; }
        public double MaxVolume { get; }
        public double Volume { get; private set; }
        public decimal Price { get; }
        public double Weight { get; private set; }

        public bool Empty { get { return Volume == 0; } }


        public Tank(string name, double maxVolume, decimal price, double weight)
        {
            Name = name;
            MaxVolume = maxVolume;
            Volume = maxVolume;
            Price = price;
            Weight = weight;
        }

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

        public override string ToString()
        {
            return Name;
        }
    }
}
