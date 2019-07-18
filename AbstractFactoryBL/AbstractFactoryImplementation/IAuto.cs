using System;

namespace AbstractFactoryBL.AbstractFactoryImplementation
{
	public interface IAuto
	{
		IBody Body { get; }
		IEngine Engine { get; }
		ITank Tank { get; }
		string Vin { get; }
		decimal Price { get; }
		double Weight { get; }

		event EventHandler<double> Moved;

		double Start(double speed);
	}
}
