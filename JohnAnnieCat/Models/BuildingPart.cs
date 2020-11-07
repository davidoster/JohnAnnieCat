using System;
namespace JohnAnnieCat.Models
{
    public class BuildingPart
    {
        private string _name;
        public string Name
        {
            get { return (this._name); }
            set { this._name = value; }
        }

        private string _type;
        public string PartType {
            get { return (this._type); }
            set { this._type = value; }
        }

        public BuildingPart()
        {
        }
    }
}
