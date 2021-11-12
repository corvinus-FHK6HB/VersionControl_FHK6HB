using Fejlesztési_minták.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fejlesztési_minták.Entities
{
    public class PresentFactory : ItoyFactory
    {
        public Color BoxColor { get; set; }
        public Color RibbonColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(BoxColor, RibbonColor);
        }
    }
}
