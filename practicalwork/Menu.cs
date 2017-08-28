using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackupAppLibrary;

namespace practicalwork
{
    public class Menu
    {
        private Storage[] _devices;
        
        public Menu(Storage[] devices)
        {
            _devices = devices;
        }
             
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
                        for (int i = 0; i < _devices.Length; i++)
                        {
                            Console.WriteLine("[" + i + "]\n" + _devices[i].GetDeviceInfo());
                        }
                         
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
