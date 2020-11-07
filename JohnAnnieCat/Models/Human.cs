using System;
namespace JohnAnnieCat.Models
{
    public class Human : Mammal
    {
        public Human()
        {
            Console.WriteLine($"This is the human {Name}");
        }

        public override void Move(Location current, Location target, Speed s) { }
        public override void Watch(Location target) { }
        public override void Look(Direction direction) { }
    }
}
