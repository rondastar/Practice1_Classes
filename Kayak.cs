using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_Classes
{
    internal class Kayak
    {
        internal enum Type { sea, river, sitOnTop }
        string _brand;
        Type _type;
        string _material;
        string _color;
        int _capacityWeight;
        int _numberOfSeats;

        public Kayak(string brand, Type type, string material, string color, int capacityWeight, int numberOfSeats)
        {
            _brand = brand;
            _type = type;
            _material = material;
            _color = color;
            _capacityWeight = capacityWeight;
            _numberOfSeats = numberOfSeats;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public Type Type1 { get => _type; set => _type = value; }
        public string Material { get => _material; set => _material = value; }
        public string Color { get => _color; set => _color = value; }
        public int CapacityWeight { get => _capacityWeight; set => _capacityWeight = value; }
        public int NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }

        public override string ToString()
        {
            return $"{Brand} {Type1} kayak - Material:{Material} - Color: {Color} - Capacity: {CapacityWeight} lbs. - Seats: {NumberOfSeats}";
        }
    }
}
