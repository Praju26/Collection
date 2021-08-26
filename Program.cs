using Collection;
using point;
using System;
using System.Collections;
using System.Collections.Generic;


namespace collection
{
    public class Program
    {
        private static bool obj;

        public static void Main()
        {

           // new ArrayList();
           // new Dictonary();
            //new StackDemo();
            //new System.Collections.Queue();

            Threads obj = new Threads();
            Console.WriteLine("Mythread ends!!");


            ArrayList data = new ArrayList();
            int v = data.Add(32);
            data.Remove(5);              // remove element
            Console.WriteLine(obj);
            Console.ReadLine();

            // adding elements using add() method
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("No of elelemts: " + primeNumbers.Count);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of elelemts: " + bigCities.Count);

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            Console.WriteLine("No of elelemts: " + students.Count);

        }
    }

    internal struct NewStruct
    {
        public x Item1;
        public object Item2;

        public NewStruct(x item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<x>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item1, Item2);
        }

        public void Deconstruct(out x item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (x, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((x, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}

