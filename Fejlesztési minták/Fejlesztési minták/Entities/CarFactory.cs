using Fejlesztési_minták.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlesztési_minták.Entities
{
    public class CarFactory : ItoyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
