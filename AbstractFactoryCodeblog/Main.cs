using AbstractFactoryBL.BaseImplementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryCodeblog
{
    public partial class Main : Form
    {
        Image carImage;
        Point carPosition;
        Car car;

        public Main()
        {
            InitializeComponent();
            carImage = Properties.Resources.CarPic1;
            carPosition = new Point(0, 0);
            var body = new Body("Priora", 1.0, 100000, 2000, 300);
            var engine = new Engine("v8", 200, 150000, 200);
            var tank = new Tank("Standard", 48, 30000, 40);

            car = new Car(body, engine, tank);

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
            var path = car.Start(50);
            carPosition.Offset((int)path, 0);
            Refresh();
        }
    }
}
