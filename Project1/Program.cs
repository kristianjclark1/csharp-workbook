using System;

namespace Project1
{


    public class Program
    {
        public static void Main()
        {
            Car snowCar = new Car("white");
            Car crashDummy = new Car("yellow");
            crashDummy.Color = "yellow and white stripes";
            // Person firstname = new Person("Mary", "Jones");


            // Garage smallGarage = new Garage(2);

            // smallGarage.ParkCar(snowCar, 0);
            // Console.WriteLine(smallGarage.Cars);
        }
    }

    class Car
    {
        public Car(string initialColor)
        {
            System.Console.WriteLine("Starting car constructor");
            System.Console.WriteLine($"This car's color is {this.Color} ");
            this.Color = initialColor;
            System.Console.WriteLine($"This car's color is {this.Color} ");


            System.Console.WriteLine("Ending car constructor");


        }
        private string _color;
        public string Color
        {
            get
            {
                //constructing color//
                System.Console.WriteLine("Starting get color");
                System.Console.WriteLine("Ending get color");
                return _color;
            }
            set
            {
                System.Console.WriteLine("Starting set color");
                _color = value;
                System.Console.WriteLine("Ending set color");
            }
        }






    }

    public class Person
    {
        public Person(string initialfirstName)
        {
            this.firstname = initialfirstName;
        }
        private string firstname
        {
            get
            {
                return this.firstname + "  ";
            }
            set
            {
                string[] names = null;
            }


        }
    }

    class Garage
    {
        private Car[] cars;

        public Garage(int initialSize)
        {
            Size = initialSize;
            this.cars = new Car[initialSize];
        }

        public int Size { get; private set; }

        public void ParkCar(Car car, int spot)
        {
            cars[spot] = car;

        }

        public string Cars
        {
            get
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null)
                    {
                        Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                    }
                }
                return "That's all!";
            }
        }
    }
}

