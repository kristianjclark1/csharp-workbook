using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            Car l1 = new Car("Sedan", 4, "ABC123", "Honda", "Civic", 20000);
            Car l2 = new Car("Coupe", 2, "DEF456", "Honda", "Civic", 18000);
            Truck l3 = new Truck("8ft", "GHI789", "Ford", "F-150", 35000);
            Truck l4 = new Truck("10ft", "JKL123", "Ford", "F-250", 40000);
            CarLotPark c1 = new CarLotPark("Austin Dealership");
            CarLotPark c2 = new CarLotPark("Houston Dealership");
            c1.vehicles.Add(l1);
            c1.vehicles.Add(l3);
            c2.vehicles.Add(l2);
            c2.vehicles.Add(l4);
            c1.PrintInventory();
            c1.PrintInventory();

        }
    }
    public class CarLotPark
    {
        public string name;
        public List<Vehicle> vehicles = new List<Vehicle>();

        public CarLotPark(string _name)
        {
            this.name = _name;
        }

        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void PrintInventory()
        {

            System.Console.WriteLine($"There are {vehicles.Count} vehicles in the lot.");
            foreach (var vehicle in vehicles)
            {
                vehicle.PrintDescription();

            }

        }



    }
    public abstract class Vehicle
    {
        //properties
        public abstract string license { get; set; }
        public abstract string make { get; set; }
        public abstract string model { get; set; }
        public abstract int price { get; set; }

        public abstract void PrintDescription();

    }

    public class Truck : Vehicle
    {
        public override string license { get; set; }
        public override string make { get; set; }
        public override string model { get; set; }
        public override int price { get; set; }
        private string bedsize;

        public Truck(string Bedsize, string License, string Make, string Model, int Price)
        {   //Acquire properties into Truck
            this.bedsize = Bedsize;
            this.license = License;
            this.make = Make;
            this.model = Model;
            this.price = Price;
        }

        public override void PrintDescription()
        {
            System.Console.WriteLine("\nLicense number: " + license + "\nMake: " + make + "\nModel: " + model + "\nBed Size: " + bedsize + "\nPrice: " + price);
        }

    }

    public class Car : Vehicle
    {
        public override string license { get; set; }
        public override string make { get; set; }
        public override string model { get; set; }
        public override int price { get; set; }
        private string type;
        private int NumberofDoors;
        public Car(string Type, int number_Of_Doors, string License, string Make, string Model, int Price)
        {
            this.type = Type;
            this.NumberofDoors = number_Of_Doors;
            this.license = License;
            this.make = Make;
            this.model = Model;
            this.price = Price;
        }

        public override void PrintDescription()
        {
            Console.WriteLine("\nType: " + type + "\nLicense number: " + license + "\nMake: " + make + "\nModel: " + model + "\nNumber of Doors: " + NumberofDoors + "\nPrice: " + price);
        }
    }
}
