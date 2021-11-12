using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    internal class CornSnake : Snake
    {
        public override bool Poisonous { get; set; } = false;
        public string CornSnakeName { get; set; } = "cornsnake";
    }
}
