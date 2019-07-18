using AbstractFactoryBL.BaseImplementation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactoryCodeblog
{
	public partial class Main : Form
	{
		private readonly Image carImage;
		private Point carPosition;
		private readonly Car car;

		public Main()
		{
			InitializeComponent();
			carImage = Properties.Resources.CarPic1;
			carPosition = new Point(0, 0);
			var body = new Body("Priora", 1.0, 100000, 2000, 300);
			var engine = new Engine("v8", 200, 150000, 200);
			var tank = new Tank("Standard", 48, 30000, 40);

			car = new Car(body, engine, tank);
			car.Moved += Car_Moved;
		}

		private void Car_Moved(object sender, double e)
		{
			carPosition.Offset((int)e, 0);
			Refresh();
		}

		private void Main_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawImage(carImage, carPosition);
		}

		private void timer_Tick(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			car.Start(50);
		}
	}
}
