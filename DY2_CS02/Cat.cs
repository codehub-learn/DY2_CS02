using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DY2_CS02
{
    public class Cat : Animal
    {
        public string? Breed { get; set; }
        public DateTime AddedDate { get; set; }
        public static string ScietificName { get; } = "Felis";
        public static List<Cat> Cats { get; set; } = new List<Cat>();

        public Cat(string name, string gender, string breed)
        {
            Name = name;
            Gender = gender;
            Breed = breed;
            AddedDate = DateTime.Now;
            Cats.Add(this);
        }

        public Cat() 
        { 
            Cats.Add(this); 
        }

        public static void PrintGenus()
        {
            Console.WriteLine(ScietificName);
        }

        public int Move(string direction, int distance) 
        {
            return distance;
        }
        public void Eat() 
        {
            Console.WriteLine(ScietificName);
      
        }
        public void Sleep() { }

        public void Yawn()
        {
            Console.WriteLine($"{this.Name} yawned");
        }

        public void Yawn(int duration)
        {
            Console.WriteLine($"{this.Name} yawned for {duration}");
        }

        public void Yawn(decimal duration)
        {
            Console.WriteLine($"{this.Name} yawned for decimal {duration}");
        }

        
    }
}
