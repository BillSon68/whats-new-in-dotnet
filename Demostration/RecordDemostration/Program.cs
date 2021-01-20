using System;

#nullable enable

namespace RecordDemostration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    #region Regular Class
    //public class Person
    //{
    //    public string? FirstName { get; set; }
    //    public string? LastName { get; set; }
    //}
    #region Test cases
    //Person person = new Person();
    //person.FirstName = "Bin";
    //        person.LastName = "Dong";
    //        Person person2 = new Person
    //        {
    //            FirstName = "Bin",
    //            LastName = "Dong",
    //        };
    #endregion
    #endregion

    #region A Simple Record
    //public record Person(string FirstName, string LastName);
    #region Test cases
    //Person person = new Person("Bin", "Dong");
    //Console.WriteLine(person.FirstName);
    //        Console.WriteLine(person.LastName);
    #endregion
    #endregion

    #region Record
    //public record Person
    //{
    //    public string? FirstName { get; init; } = "Test";
    //    public string? LastName { get; init; } = "Test";
    //}
    #region Test cases
    //Person person = new Person()
    //{
    //    FirstName = "Bin",
    //};
    //Console.WriteLine(person);
    #endregion
    #endregion

    #region ComplicatedRecord
    //public record Person(string FirstName)
    //{
    //    public int Id { get; init; }

    //    private readonly string _lastName;
    //    public string LastName {
    //        get => _lastName;
    //        init => _lastName = value;
    //    }
    //}
    #endregion

    #region With expression
    //public record Person(string FirstName, string LastName);

    #region Test cases
    //Person person1 = new Person("Bin", "Dong");
    //Person person2 = person1 with { FirstName = "Xiaoxiao" };
    //Console.WriteLine(person2);
    #endregion
    #endregion
}

