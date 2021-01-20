using System;
using System.Collections.Generic;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type matching
            //IEnumerable<Person> persons = GetPersons();
            //foreach (var person in persons)
            //{
            //    switch (person)
            //    {
            //        case Teacher: Console.WriteLine("Teacher"); break;
            //        case Student:
            //            Console.WriteLine("Student"); break;
            //        _: Console.WriteLine("Not sure");
            //    }
            //}
            #endregion
            #region Logic matching
            //bool IsLetter(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

            //if(string.Empty is not null)
            //{
            //    Console.WriteLine("Hello .NET!");
            //}
            #endregion
            #region Relational matching
            //IEnumerable<Person> persons = GetPersons();
            //foreach (var person in persons)
            //{
            //    person.FirstName = person.Age switch
            //    {
            //        > 5 => "Old",
            //        < 5 => "Yound",
            //        _ => "Middle"
            //    };
            //    Console.WriteLine(person.FirstName);
            //}
            #endregion
        }


        static IEnumerable<Person> GetPersons()
        {
            
            for(int i = 0; i< 10; i++)
            {
                if (i % 2 == 0)
                {
                    yield return new Teacher() { Age = i};
                }
                else
                {
                    yield return new Student() { Age = i };
                }
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Teacher : Person
    {

    }

    public class Student: Person
    {

    }
}
