using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    public class Dog : Animal
    {
        public void Bark() { }
        public DateTime CreationDate { get; set; }

        public override void Move(int distance)
        {
            Console.WriteLine("The dog moves");
        }

        public Dog()
        {
            CreationDate = DateTime.Now;
        }
    }
}
