using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryBL.BaseImplementation
{
    public class Car
    {
        public Body Body { get; }
        public Engine Engine { get; }
        public Tank Tank { get; }
        public string Vin { get; }
        public decimal Price { get; }
        public double Weight
        {
            get
            {
                return Body.Weight + Engine.Weight + Tank.Weight;
            }
        }
        

        public Car(Body body, Engine engine, Tank tank)
        {
            Body = body;
            Engine = engine;
            Tank = tank;
            Price = Body.Price + Engine.Price + Tank.Price;
            
            Vin = Guid.NewGuid().ToString();
        }

        public double Start(double speed)
        {
            if(Weight > Body.MaxWeight)
            {
                throw new Exception("Вес автомобиля больше максимального. Движение не возможно.");
            }

            var path = 0.0;
            while(!Tank.Empty)
            {
                path += Step(speed);
            }

            return path;
        }

        private double Step(double speed)
        {
            var actualSpeed = speed < Engine.MaxSpeed ? speed : Engine.MaxSpeed;
            actualSpeed *= Body.Aerodynamic;
            var needFuel = Engine.GetConsumption(actualSpeed);
            var pathRate = Tank.Spend(needFuel);
            var path = actualSpeed * pathRate;
            return path;
        }

        public override string ToString()
        {
            return Vin;
        }
    }
}
