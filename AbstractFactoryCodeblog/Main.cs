using AbstractFactoryBL.AbstractFactoryImplementation;
using AbstractFactoryBL.BaseImplementation;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AbstractFactoryCodeblog
{
	public partial class Main : Form
	{
		private readonly Image carImage;
		private readonly int pause = 500;

		private IAutoFactory factory;

		public Main()
		{
			InitializeComponent();
			carImage = Properties.Resources.CarPic1;
			speedLabel.Text = speedTrackBar.Value.ToString();
		}

		#region Базовая реализация
		private Car CreateBaseImplementationCar()
		{
			var body = new Body("Priora", 1.0, 100000, 2000, 300);
			var engine = new Engine("v8", 200, 150000, 200);
			var tank = new Tank("Standard", 48, 30000, 40);

			var car = new Car(body, engine, tank);
			car.Moved += BaseCarMoved;

			return car;
		}

		private void BaseCarStartButtonClick(object sender, EventArgs e)
		{
			pathLabel.Text = $"Пройдено:";
			var speed = speedTrackBar.Value;
			var baseCar = CreateBaseImplementationCar();
			baseCar.Start(speed);
		}

		private void BaseCarMoved(object sender, double e)
		{
			Refresh();
			var y = 10;
			var x = (int)e;
			var graphics = CreateGraphics();
			graphics.DrawImage(carImage, x, y);
			pathLabel.Text = $"Пройдено: {x}";
			Thread.Sleep(pause);
		}
		#endregion

		#region Реализация с помощью абстрактной фабрики
		private void FactoryCarButtonClick(object sender, EventArgs e)
		{
			if(factory == null)
			{
				MessageBox.Show("Выберите тип автомобиля: Ока или Камаз.", "Не выбран тип.", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			pathLabel.Text = $"Пройдено:";
			var speed = speedTrackBar.Value;
			var auto = new Auto(factory);
			auto.Moved += AutoMoved;
			auto.Start(speed);
		}

		private void AutoMoved(object sender, double e)
		{
			Refresh();
			var y = 10;
			var x = (int)e;
			var graphics = CreateGraphics();
			graphics.DrawImage(carImage, x, y);
			pathLabel.Text = $"Пройдено: {x}";
			Thread.Sleep(pause);
		}

		private void CarRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			factory = new CarFactory();
		}

		private void TruckRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			factory = new TruckFactory();
		}
		#endregion

		private void SpeedTrackBarScroll(object sender, EventArgs e)
		{
			speedLabel.Text = speedTrackBar.Value.ToString();
		}
	}
}
