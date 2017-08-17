using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classwork
{
    public abstract class Person
    {

        protected int data;

        public long Id { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }

        public Person(long id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }


        public abstract void ToDo();

        public virtual void ToDo2()
        {
            Console.WriteLine();
        }
    }
}
