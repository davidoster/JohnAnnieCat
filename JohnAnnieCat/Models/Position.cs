using System;
namespace JohnAnnieCat.Models
{
    public class Position
    {
        private float _x, _y, _z;
        public float X {
            get { return (this._x); }
            set { this._x = value; }
        }

        public float Y
        {
            get { return (this._y); }
            set { this._y = value; }
        }

        public float Z
        {
            get { return (this._z); }
            set { this._z = value; }
        }

        public Position()
        {
        }
    }
}
