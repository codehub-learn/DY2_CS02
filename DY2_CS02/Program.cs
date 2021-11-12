namespace DY2_CS02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Cat cadife = new Cat("Cadife", "Female", "Calico");
            Cat annie = new Cat("Annie", "Female", "Shorthair");
            int x = (int)5.24m;
            Cat mycat = new Cat();
            Console.WriteLine(mycat.Name);
            Console.WriteLine(mycat.Age);
            annie.Eat();
            annie.Move("left", 100);
            annie.Yawn();
            annie.Yawn(10);
            annie.Yawn(10.25m);
            Console.WriteLine(annie.AddedDate);
            Console.WriteLine(Cat.ScietificName);

            Snake snake = new Snake();
            snake.Length = -1;
            Console.WriteLine(snake.Length);
            SalesOperations.Buy();

            annie.Age = 10;

            Dog dog = new Dog();
            dog.Age = 10;
            dog.Name = "Brian";
            dog.Eat();

            Dog roomy = new Dog()
            {
                Name = "Roomy",
                Age = 8,
                Gender = "Female"
            };

            Dog roomy2 = new Dog();
            roomy2.Name = "Roomy";
            roomy2.Age = 8;
            roomy2.Gender = "Female";

            Mamba mamba = new Mamba();
            Console.WriteLine(mamba.Poisonous);

            CornSnake cornSnake = new CornSnake();
            Console.WriteLine(cornSnake.Poisonous);

            Console.WriteLine("------");
            
            Snake snake2 = new CornSnake();
            CornSnake newSake = (CornSnake)snake2;
            Console.WriteLine("Cornske Name: " + newSake.CornSnakeName);

            Console.WriteLine(snake2.Poisonous);
            List<Snake> list = new List<Snake>();
            list.Add(cornSnake);
            list.Add(mamba);

            IShape shape = new Triangle();
            shape.GetArea();
        }
    }
}
