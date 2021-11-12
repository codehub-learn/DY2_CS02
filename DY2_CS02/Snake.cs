using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    internal class Snake : Animal
    {
        public virtual bool Poisonous { get; set; } = true;

        private float _length;
        public float Length {
            get { 
                return _length; 
            }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Length cannot be less than 0");
                    return;
                }

                _length = value;
            }
        }

        public virtual void Slither() 
        {
            Console.WriteLine("The snake moves");
        }

        public override void Move(int dist) { }
 
    }
}
