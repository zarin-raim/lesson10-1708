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
        public override void CopyDataToDevice(File[] files, out double timeSpend, out File[] remainingFiles)
        {
            double filesSize = 0;

            int i = 0;
            while(filesSize < StorageValue)
                filesSize += files[i++].Size;                        //объем который запишется

            timeSpend = filesSize / SpeedUsb30;
            FreeSpace = StorageValue - filesSize;

            remainingFiles = new File[files.Length - i];
            int j = 0;
            while (i < files.Length)
                remainingFiles[j++] = files[i];            
        }

        public override string GetDeviceInfo()
        {
            return String.Format("{0}{1}\nSpeed - {2}\nStorage Value - {3}\nFree Space - {4}\n", Name, Model, SpeedUsb30, StorageValue, FreeSpace);
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
