using System;
namespace JohnAnnieCat.Models
{
    public class House : BuildingPart
    {
        private Interior _interior = new Interior();
        public Interior Interior {
            get { return (this._interior); }
            set { this._interior = value;  }
        }

        private Garden _garden = new Garden();
        public Garden Garden
        {
            get
            {
                return (this._garden);
            }

            set
            {
                this._garden = value;
            }
        }

        public House()
        {
            this._interior.Name = "Interior";
            this._garden.Name = "Garden";
            this.PartType = "This is the whole house";
            this.Name = "House";

            
        }

        public House(Interior interior, Garden garden)
        {
            this._interior = interior;
            this._garden = garden;
        }

        public override string ToString()
        {
            return($"{PartType} {Name} with {_interior.PartType} {_interior.Name} {_garden.PartType} {_garden.Name}");
        }
    }
}
