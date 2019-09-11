using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    class Iterator : IAbstractIterator
    {
        private Collection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }
        public Item CurrentItem
        {
            get
            {
                return collection[current] as Item;
            }
        }

        public bool IsDone
        {
            get
            {
                return current >= collection.Count;
            }
        }

        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Item;
            else
                return null;
        }
    }

    class Item
    {
        public string name;
        public Item(string name)
        {
            this.name = name;
        }
    }

    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }

    class Collection : IAbstractCollection
    {
        private ArrayList items = new ArrayList();
        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
    }

    class IteratorPatternExample
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new Item("Item1");
            collection[1] = new Item("Item2");
            collection[2] = new Item("Item3");
            collection[3] = new Item("Item4");
            collection[4] = new Item("Item5");
            collection[5] = new Item("Item6");

            Iterator iterator = collection.CreateIterator();

            //iterator.step = 1;
            Console.WriteLine("Iterating over collection");
            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.name);
            }

            Console.Read();
        }
    }
}
