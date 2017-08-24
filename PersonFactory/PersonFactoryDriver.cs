using System;
using System.Collections.Generic;

namespace DesignPatterns
{

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PersonFactory
    {
        private List<Person> allPeople;
        private Person person;
        public PersonFactory()
        {
            allPeople = new List<Person>();            
        }

        public Person CreatePerson(string name)
        {
            person = new Person();
            this.person.Id = allPeople.Count;
            this.person.Name = name;
            allPeople.Add(person);
            return person;
        }

        public void PrintPeople()
        {
            foreach (var person in allPeople)
            {
                Console.WriteLine($"{person.Id}: {person.Name}");
            }
        }
    }


    public static class PersonFactoryDriver
    {
        public static void Do()
        {
            var pf = new PersonFactory();
            pf.CreatePerson("bob");
            pf.CreatePerson("mary");
            pf.PrintPeople();

        }
    }
}