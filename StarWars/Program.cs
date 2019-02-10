using System;

public class Program
{
    public static void Main()
    {
        Station deathStar = new Station("DeathStar", 2, "Imperial");
        Station rebelSpaceStation = new Station("RebelSpaceStation", 2, "Rebel");
        Person leia = new Person("Leia", "Organa", "Rebel");
        Person luke = new Person("Luke", "Skywalker", "Rebel");
        Ship falcon = new Ship("Rebel", "Smuggling", 2);
        Ship tie = new Ship("Tie", "Fighter", 1);
        Station smallStation = new Station("Rebel", 2, "Rebel");
        smallStation.ParkShip(tie, 0);
        tie.addPerson(leia, 0);
        Console.WriteLine(smallStation.Roster);

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
                if (person != null)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }
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
    public string Name { get; private set; }
    public int Size { get; private set; }
    public string Alliance { get; private set; }

    public Station(string initialName, int initialSize, string alliance)
    {
        this.Name = initialName;
        this.ships = new Ship[initialSize];
        this.Size = initialSize;
        this.Alliance = alliance;
    }

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
                    Console.WriteLine(String.Format("The {0} ship is in spot {1} and the people on that ship are:", ships[i].Type, i));
                    Console.WriteLine(ships[i].Passengers);
                }
            }
            return "That's all!";

        }
    }
}