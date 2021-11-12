using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Fejlesztési_minták.Abstractions;

namespace Fejlesztési_minták.Entities
{
    public class Ball : Toy
    {
        public SolidBrush Ballcolor { get; private set; }
        public Ball(Color color)
        {
            Ballcolor = new SolidBrush(color);
        }
        protected override void DrawImage(Graphics g)
        {
            //Brush ecset = new SolidBrush(Color.Blue);
            g.FillEllipse(
                Ballcolor,
                0,
                0,
                Width,
                Height);
        } 
    }
}
