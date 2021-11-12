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
        protected override void DrawImage(Graphics g)
        {
            //Brush ecset = new SolidBrush(Color.Blue);
            g.FillEllipse(
                new SolidBrush(Color.Blue),
                0,
                0,
                Width,
                Height);
        } 
    }
}
