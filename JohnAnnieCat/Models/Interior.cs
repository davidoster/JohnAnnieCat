using System;
using System.Collections.Generic;

namespace JohnAnnieCat.Models
{
    public class Interior : BuildingPart 
    {
        public List<Mammal> mammals = new List<Mammal>();
        public Interior()
        {
            this.PartType = "I am the interior";
        }

        public Interior(Mammal human = null, Mammal animal = null)
        {
            mammals.Add(human);
            mammals.Add(animal);
        }
    }
}
