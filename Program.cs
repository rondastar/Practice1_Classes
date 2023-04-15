// See https://aka.ms/new-console-template for more information
using Practice1_Classes;

// Instance of Car
Car car = new Car("Toyota", "Prius", 2014, "Grey", 58000);
Console.WriteLine(car.ToString());

// Instance of Bike
Bike bike = new Bike("BMX", (Bike.Type)1, "green", 2);
Console.WriteLine(bike.ToString());

// Instance of Kayak
// public Kayak(string brand, Type type, string material, string color, int capacityWeight, int numberOfSeats)
Kayak kayak = new Kayak("Easyrider", 0, "carbon fiber", "teal", 250, 1 );
Console.WriteLine(kayak.ToString());