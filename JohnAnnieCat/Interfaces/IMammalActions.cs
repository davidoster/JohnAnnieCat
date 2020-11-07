using System;
using JohnAnnieCat.Models;

namespace JohnAnnieCat.Interfaces
{
    public interface IMammalActions
    { 
        void Move(Location current, Location target, Speed s);
        void Watch(Location target);
        void Look(Direction direction);
    }
}
