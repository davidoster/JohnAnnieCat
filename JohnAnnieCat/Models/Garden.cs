using System;
using System.Collections.Generic;

namespace JohnAnnieCat.Models
{
    public class Garden : BuildingPart
    {
        public Garden()
        {
            this.PartType = "I am the garden";
        }

        public Garden(List<Mammal> mammals = null)
        {

        }
    }
}
