using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classwork
{
    class Program
    {
        //sealed - для запрета наследников 
        //partial - разбитый на несколько файлов класс
        //abstract - для запрета объектов этого типа

        static void Main(string[] args)
        {
            int number = 5;
            Object obj = number;
            int number2 = (int)obj;



            //Person person = new Person();
            //Person doctor = new Doctor();
            //((Doctor)doctor).Salary = 1000;

            ////is/as

            //if(doctor is Doctor)
            //{
                
            //}

            //(doctor as Doctor).Salary = 1;
        }
    }
}
