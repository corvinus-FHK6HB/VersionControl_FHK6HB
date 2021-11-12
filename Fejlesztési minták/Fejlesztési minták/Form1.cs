using Fejlesztési_minták.Abstractions;
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

        List<Toy> _toys = new List<Toy>();
        private ItoyFactory _toyFactory;

        public ItoyFactory ToyFactory
        {
            get { return _toyFactory; }
            set { _toyFactory = value; }
        }


        public Form1()
        {
            InitializeComponent();
            ToyFactory = new CarFactory();



        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = ToyFactory.CreateNew();
            _toys.Add(toy);
            mainPanel.Controls.Add(toy);
            toy.Left = -toy.Width;
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var lastPosition = 0;
            foreach (var item in _toys)
            {
                item.MoveToy();
                if (item.Left>lastPosition)
                {
                    lastPosition = item.Left;
                }
            }
            if(lastPosition>1000)
            {
                var oldesttoy = _toys[0];
                _toys.Remove(oldesttoy);
                mainPanel.Controls.Remove(oldesttoy);
            }
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }
    }
}
