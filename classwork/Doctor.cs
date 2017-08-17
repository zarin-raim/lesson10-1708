using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classwork
{
    public class Doctor : Person
    {
        public int Salary { get; set; }
        public DateTime CreationDate { get; set; }

        public Doctor(long id, string firstName, string lastName, DateTime creationDate) 
            : base(id, firstName, lastName)
        {
            base.ToDo2();
        }
        
        public override void ToDo()
        {
            data = 3;
        }


        public override void ToDo2()
        {
            Console.WriteLine("dD");
        }

    }
}
