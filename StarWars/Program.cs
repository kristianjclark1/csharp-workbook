using System;

public class Program
{
    public static void Main()
    {
        Station star = new Station("Star");
        Station rebel = new Station("Rebel");
        Person leia = new Person("Leia", "Organa", "Rebel");
        Person luke = new Person("Luke", "Skywalker", "Rebel");
        Ship falcon = new Ship("Rebel", "Smuggling", 2);
        Ship tie = new Ship("Tie", "Fighter", 1);
        Station smallStation = new Station(2);
        smallStation.ParkShip(tie, 0);
        Console.WriteLine(smallStation.Roster);
        Console.WriteLine("Hello world!");
    }
}

class Person
{
    private string firstName;
    private string lastName;
    private string alliance;
    public Person(string firstName, string lastName, string alliance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.alliance = alliance;
    }

    public string FullName
    {
        get
        {
            return this.firstName + " " + this.lastName;
        }

        set
        {
            string[] names = value.Split(' ');
            this.firstName = names[0];
            this.lastName = names[1];
        }
    }
}

class Ship
{
    private Person[] passengers;
    public Ship(string initialName)
    {
        Name = initialName;
    }
    public string Name { get; private set; }
    public Ship(string alliance, string type, int size)
    {
        this.Type = type;
        this.Alliance = alliance;
        this.passengers = new Person[size];
    }

    public string Type
    {
        get;
        set;
    }

    public string Alliance
    {
        get;
        set;
    }

    public string Passengers
    {
        get
        {
            foreach (var person in passengers)
            {
                Console.WriteLine(String.Format("{0}", person.FullName));
            }

            return "That's Everybody!";
        }
    }
    public void addPerson(Person passengers, int spot)
    {
        this.passengers[spot] = passengers;
    }


    public void EnterShip(Person person, int seat)
    {
        this.passengers[seat] = person;
    }

    public void ExitShip(int seat)
    {
        this.passengers[seat] = null;
    }
}

class Station
{
    private Ship[] ships;
    public Station(string initialName)
    {
        Name = initialName;
    }
    public string Name { get; private set; }
    public Station(int initialSize)
    {
        Size = initialSize;
        this.ships = new Ship[initialSize];
    }
    public int Size { get; private set; }
    public void ParkShip(Ship ship, int spot)
    {
        ships[spot] = ship;
    }
    public void ExitStation(int spot)
    {
        this.ships[spot] = null;
    }

    public string Roster
    {
        get
        {
            for (int i = 0; i < ships.Length; i++)
            {
                if (ships[i] != null)
                {
                    Console.WriteLine(String.Format("The {0} ship is in spot {1} ", ships[i].Type, i));
                }
            }
            return "That's all!";

        }
    }
}