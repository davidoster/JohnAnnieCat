using System;
namespace JohnAnnieCat.Models
{
    public class Location
    {
        private Position _position;
        public Position Position {
            get { return (this._position);  }
            set { this._position = value; }
        }

        public Location()
        {
        }
    }
}
