using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    public abstract class Animal
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string Greeting { get; } = "Hello from animal";

        public Animal (string Name) { this.Name = Name; }

        public void Eat() { }
    }
}
