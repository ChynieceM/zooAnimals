namespace zooAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Peacock = new Animal();

            Peacock.Name = "Peacock";
            Peacock.Color = "rainbow";
            Peacock.Legs = 2;
            Peacock.IsEating = true;
            Peacock.IsSleeping = false;
          

            Console.WriteLine($"This animal is a {Peacock.Name} with {Peacock.Legs} legs and is {Peacock.Color} colored. Is Eating? {true}. Is Sleeping? {false}" );
            Console.ReadLine();

            Animal Elephant = new Animal();

            Elephant.Name = "Elephant";
            Elephant.Color = "grey";
            Elephant.Legs = 4;
            Elephant.IsEating = false;
            Elephant.IsSleeping = true;

            Console.WriteLine($"This animal is a {Elephant.Name} with {Elephant.Legs} legs and is {Elephant.Color}. Is Eating? {false} . Is Sleeping?  {true}");
            Console.ReadLine();

            Animal TRex = new Animal();

            TRex.Name = "T-Rex";
            TRex.Color = "Red and Blue";
            TRex.Legs = 4;
            TRex.IsEating = true;
            TRex.IsSleeping = false;

            Console.WriteLine($"This animal is a {TRex.Name} with {TRex.Legs}and is {TRex.Color}. Is Eating? {true}. Is Sleeping? {false}");
            Console.ReadLine();
        }
    }
}