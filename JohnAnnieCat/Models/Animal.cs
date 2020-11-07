using System;
namespace JohnAnnieCat.Models
{
    public class Animal : Mammal
    {
        public Animal()
        {
            Console.WriteLine($"This is the animal {Name}");
        }

        public override void Move(Location current, Location target, Speed s) { }
        public override void Watch(Location target) { }
        public override void Look(Direction direction) { }
    }
}
