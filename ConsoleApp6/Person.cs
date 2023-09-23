using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public void AddPerson(List<Person> people, Person person)
        {
            people.Add(person);
        }

        public void RemovePerson(List<Person> people, Person person)
        {
            people.Remove(person);
        }

        public static void DeletePersonByName(List<Person> people, string name)
        {
            Person p = null;
            foreach(var item in people)
            {

                if (item.Name == name)
                    p = item;
            }
            people.Remove(p);
        }

        public static void UpdateName(List<Person> people, string oldName, string newName)
        {
            for(int i = 0; i < people.Count; i++)
            {
                if(people[i].Name == oldName)
                {
                    people[i].LastName = newName;
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {LastName} {Birthdate.ToShortDateString()}";
        }
    }
}
