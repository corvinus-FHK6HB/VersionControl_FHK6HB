using Fejlesztési_minták.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fejlesztési_minták
{
    public partial class Form1 : Form
    {

        List<Ball> _balls = new List<Ball>();
        private BallFactory _ballFactory;

        public BallFactory Ballfactory
        {
            get { return _ballFactory; }
            set { _ballFactory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            Ballfactory = new BallFactory();



        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var ball = Ballfactory.CreateNew();
            _balls.Add(ball);
            mainPanel.Controls.Add(ball);
            ball.Left = -ball.Width;
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var lastPosition = 0;
            foreach (var item in _balls)
            {
                item.MoveBall();
                if (item.Left>lastPosition)
                {
                    lastPosition = item.Left;
                }
            }
            if(lastPosition>1000)
            {
                var oldestBall = _balls[0];
                _balls.Remove(oldestBall);
                mainPanel.Controls.Remove(oldestBall);
            }
        }
    }
}
