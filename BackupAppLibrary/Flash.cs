using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupAppLibrary
{
    public class Flash : Storage
    {
        private double _speedUsb30;
        private double _storageValue;
        private double _freeSpace;

        public Flash()
        {
            SpeedUsb30 = 625;      //MBps
            StorageValue = 4000;   //MB
            FreeSpace = StorageValue;
            Name = "Flash Drive";
            Model = String.Format("{0}GB USB3.0", StorageValue / 1000);
        }
        
#region Accessors
        public double SpeedUsb30
        {
            get { return _speedUsb30; }
            set { _speedUsb30 = value; }
        }
        public double StorageValue
        {
            get { return _storageValue; }
            set { _storageValue = value; }
        }
        public double FreeSpace
        {
            get { return _freeSpace; }
            set { _freeSpace = value; }
        }
        #endregion

        #region Methods
        public override int CopyDataToDevice(File[] files, out DateTime time, out double remainingValue)
        {
            double filesSize = 0;
            for (int i = 0; i < files.Length; i++)
                filesSize += files[i].Size;                        //объем который нужно записать

            int devices = (int)(filesSize / StorageValue);         //колличество необходимых устройств этого вида

            remainingValue = filesSize - (devices * StorageValue); //непоместившийся объем памяти

            if (remainingValue <= 0)
                FreeSpace = StorageValue - filesSize;              //вычисление свободного места, если все файлы записались полностью

            return devices;
        }

        public override string GetDeviceInfo()
        {
            return String.Format("\nSpeed USB3.0 - {0}\nStorage Value - {1}\nFree Space - {2}", SpeedUsb30, StorageValue, FreeSpace);
        }

        public override double GetFreeSpaceValue()
        {
            throw new NotImplementedException();
        }

        public override double GetStorageValue()
        {
            return StorageValue;
        }
#endregion

    }
}
