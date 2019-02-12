using System;
using System.Collections.Generic;

namespace OtherRainForest
{
    class Program
    {
        public static void Main()
        {
            Container c1 = new Container(02, "Austin 01");
            Container c2 = new Container(02, "Houston 01");
            Item l1 = new Item("Bananas", 2.50);
            Item l2 = new Item("Grapes", 1.75);
            Item l3 = new Item("Apples", .75);
            Warehouse w1 = new Warehouse("Austin", 2);
            Warehouse w2 = new Warehouse("Houston", 2);
            Company Rainforest = new Company("Rainforest");
            Rainforest.warehouses.Add(w1);
            Rainforest.warehouses.Add(w2);
            w1.containers.Add(c1);
            w2.containers.Add(c2);
            c1.items.Add(l1);
            c1.items.Add(l2);
            c2.items.Add(l3);
            Manifest(Rainforest);
            System.Console.WriteLine();
            Index(Rainforest, l2);


        }
        public static void Manifest(Company company)
        {
            System.Console.WriteLine("{0}", company.Name);
            foreach (Warehouse warehouse in company.warehouses)
            {
                System.Console.WriteLine("{0}".PadLeft(4), warehouse.Location);
                foreach (Container container in warehouse.containers)
                {
                    System.Console.WriteLine("{0}".PadLeft(8), container.id);
                    foreach (Item _items in container.items)
                    {
                        System.Console.WriteLine("{0}".PadLeft(12), _items.Name);
                    }
                }
            }

        }
        public static void Index(Company company, Item Item)
        {
            Dictionary<Item, Container> indexer = new Dictionary<Item, Container>();
            foreach (Warehouse warehouse in company.warehouses)
            {

                foreach (Container container in warehouse.containers)
                {

                    foreach (Item _items in container.items)
                    {
                        indexer.Add(_items, container);
                    }
                }
            }
            if (indexer.ContainsKey(Item))
            {
                Container value = indexer[Item];
                System.Console.WriteLine("{0} is found in {1}", Item.Name, value.id);
            }
        }
    }

    class Company
    {
        public List<Warehouse> warehouses = new List<Warehouse>();
        public string Name { get; set; }
        public Company(string name)
        {
            this.Name = name;
        }
    }




    class Warehouse
    {
        public string Location { get; set; }
        public int Size { get; set; }
        public List<Container> containers = new List<Container>();
        public Warehouse(string Location, int size)
        {
            this.Location = Location;
            this.Size = size;
        }
    }

    class Container
    {
        public int Size { get; set; }
        public string id { get; set; }
        public List<Item> items = new List<Item>();
        public Container(int size, string Id)
        {
            this.Size = size;
            this.id = Id;
        }




    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;

        }


    }
}
