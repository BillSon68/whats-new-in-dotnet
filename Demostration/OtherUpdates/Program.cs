using System;
using System.Collections.Generic;

namespace OtherUpdates
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region Foreach pattern
    public class EnumerableClass
    {
        public SampleEnumerator GetEnumerator()
        {
            return new SampleEnumerator();
        }

        public class SampleEnumerator
        {
            public int Current { get; set; } = 10;
            public bool MoveNext()
            {
                Current--;
                return Current!=0;
            }
        }
    }
    #endregion

    #region Covariant returns
    public class Animal
    {
        public virtual Food Eat()
        {
            return new Food();
        }
    }

    public class Tiger:Animal
    {
        public override Meat Eat()
        {
            return new Meat();
        }
    }

    public class Food { }
    public class Meat : Food { }
    #endregion


}
