using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackupAppLibrary
{
    public abstract class Storage
    {
        private string _name;
        private string _model;

        public string Name
        {
            get { return _name; }
            set { _model = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public abstract double GetStorageValue();
        public abstract void CopyDataToDevice(File[] files, out double timeSpend, out File[] remainingFiles);
        public abstract double GetFreeSpaceValue();
        public abstract string GetDeviceInfo();
    }
}
