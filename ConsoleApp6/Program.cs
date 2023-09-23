
using ConsoleApp6;

public class Program
    {
         static void Main()
        {
            List<Person> people = new List<Person>() {
            new Person(){ Name = "John",LastName = "Doe", Birthdate = new DateTime(1985,5,8)},
            new Person() { Name = "Jane",LastName = "Doe", Birthdate = new DateTime(1985, 6, 8)},
            new Person(){ Name = "Josh",LastName = "Broe", Birthdate = new DateTime(1972,4,9)},
            new Person(){ Name = "Jill",LastName = "Soe", Birthdate = new DateTime(1999,9,9)},
            new Person(){ Name = "Jock",LastName = "Toe", Birthdate = new DateTime(1995,2,3)},
            };


            Person p = (new Person() { Name = "Sock", LastName = "Loe", Birthdate = DateTime.Now});

            people.Add(p);

        Person.DeletePersonByName(people, "Jock");


            foreach(var item in people)
            {
                Console.WriteLine(item);
            }

            List<int> ints = new List<int>()
            {
                120,23123,23,23,44,234
            };

        ints.AddRange(new int[] { 11, 22, 33 });

        ints.Insert(4, 99);

        //ints.Remove(23);
        //ints.RemoveAll(i => i == 23);
        //ints.RemoveAt(0);
        //ints.RemoveRange(3, 4);

        ints.Sort();
        //ints.Reverse();

        //Console.WriteLine(ints.Contains(23));

             foreach(var item in ints)
             {
               Console.WriteLine(item);
             }

        }
    }
