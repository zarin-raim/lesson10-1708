using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practicalwork
{
    public class Menu
    {
        public void DrawMainMenu()
        {
            Console.WriteLine
                (
                    "1 - Доступные устройства\n" +
                    "2 - Перенести данные\n" +
                    "0 - Выход\n"
                );
        }


        public void Handler()
        {
            string key = "";
            while(key != "0")
            {
                Console.Write("Действие: ");
                key = Console.ReadLine();

                Console.Clear();
                switch (key)
                {
                    case "1":
                        
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
