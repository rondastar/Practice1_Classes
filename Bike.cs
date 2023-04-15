using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_Classes
{
    internal class Bike
    {
        internal enum Type { electric, mountain, unicycle }
        string _brand;
        Type _type;
        string _color;
        int _numberOfWheels;

        public Bike(string brand, Type type, string color, int numberOfWheels)
        {
            _brand = brand;
            _type = type;
            _color = color;
            _numberOfWheels = numberOfWheels;
        }

        public string Brand { get => _brand; set => _brand = value; }
        internal Type Type1 { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int NumberOfWheels { get => _numberOfWheels; set => _numberOfWheels = value; }

        public override string ToString()
        {
            return $"{Brand} - Type: {Type1} - Color: {Color} - Wheels: {NumberOfWheels}";
        }
    }
}
