using System;

namespace Project1
{


    public class Program
    {
        public static void Main()
        {
            Garage smallGarage = new Garage(2);
            Car blueCar = new Car("blue", 5);
            Person mary = new Person("Mary");
            Person sue = new Person("Sue");
            blueCar.addPerson(mary, 0);
            blueCar.addPerson(sue, 1);
            smallGarage.ParkCar(blueCar, 0);
            System.Console.WriteLine(smallGarage.Cars);

        }
    }

    public class Car
    {
        private Person[] people;
        public Car(string color, int size)
        {
            this.Color = color;
            this.people = new Person[size];
        }
        public string Color;
        public void addPerson(Person person, int spot)
        {
            this.people[spot] = person;
        }
        public string Persons
        {
            get
            {
                string peopleNames = "";
                for (int i = 0; i < people.Length; i++)
                {
                    if (people[i] != null)
                    {
                        peopleNames += people[i].name + " ";
                    }

                }
                return peopleNames;
            }
        }


    }

    public class Person
    {
        public string name { get; set; }
        public Person(string initialName)
        {
            this.name = initialName;
        }
    }

    class Garage
    {
        private Car[] cars;

        public Garage(int initialSize)
        {
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
                        Console.WriteLine(String.Format("The {0} car is in spot {1} and the people in that car are: {2}.", cars[i].Color, i, cars[i].Persons));
                    }
                }
                return "That's all!";
            }
        }

    }
}

