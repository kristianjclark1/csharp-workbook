using System;

namespace Project1
{


    public class Program
    {
        public static void Main()
        {
            Car snowCar = new Car("white");
            Car magicalCar = new Car("rainbow");
            Car hippyCar = new Car("tiedye");

            Person firstname = new Person("Mary", "Jones");

            Garage smallGarage = new Garage(2);

            smallGarage.ParkCar(snowCar, 0);
            Console.WriteLine(smallGarage.Cars);
        }
    }

    class Car
    {
        public Car(string initialColor)
        {
            this.snowCar = initialColor;

        }

        public string Color { get; private set; }



    }

    class Person
    {
        public Person(string initialfirstName)
        {
            this.firstname = initialfirstName;
        }
        private string firstname;
        {
            get
            {
                return this.firstname
    }
    set
            {

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

