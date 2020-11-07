using System;
using JohnAnnieCat.Interfaces;

namespace JohnAnnieCat.Models
{
    abstract public class Mammal : IMammalActions
    {
        private string _name;
        public string Name
        {
            get { return (this._name); }
            set { this._name = value; }
        }

        public Mammal()
        {
            Console.WriteLine("This is a mammal");  
        }

        abstract public void Move(Location current, Location target, Speed s);
        abstract public void Watch(Location target);
        abstract public void Look(Direction direction);
    }
}
