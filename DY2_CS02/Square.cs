using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    internal class Square : IShape
    {
        public float width { get; set; }
        public float height { get; set; }

        public float GetArea()
        {
            return width * height;
        }
    }
}
