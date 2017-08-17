using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person doctor = new Doctor();
            ((Doctor)doctor).Salary = 1000;

            //is/as

            if(doctor is Doctor)
            {
                
            }

            (doctor as Doctor).Salary = 1;
        }
    }
}
