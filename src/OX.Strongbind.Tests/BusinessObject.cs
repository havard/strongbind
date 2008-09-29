namespace OX.Strongbind.Tests
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    public class BusinessObject : IBusinessObject, INotifyPropertyChanged
    {
        private string name;
        private int intValue;
        private short shortValue;
        private long longValue;
        private uint uintValue;
        private ushort ushortValue;
        private ulong ulongValue;
        private float floatValue;
        private double doubleValue;
        private decimal decimalValue;
        private Point pointValue;
        private Size sizeValue;

        public BusinessObject()
        {
            name = Guid.NewGuid().ToString();
            intValue = 20;
            shortValue = 20;
            longValue = 20;
            uintValue = 20;
            ushortValue = 20;
            ulongValue = 20;
            floatValue = 1.0f;
            doubleValue = 1.0;
            decimalValue = 1.0m;
            pointValue = new Point(20, 20);
            sizeValue = new Size(20, 20);
        }

        #region IBusinessObject members

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int IntValue
        {
            get
            {
                return intValue;
            }
            set
            {
                intValue = value;
                OnPropertyChanged("IntValue");
            }
        }

        public short ShortValue
        {
            get
            {
                return shortValue;
            }
            set
            {
                shortValue = value;
                OnPropertyChanged("ShortValue");
            }
        }

        public long LongValue
        {
            get
            {
                return longValue;
            }
            set
            {
                longValue = value;
                OnPropertyChanged("LongValue");
            }
        }

        public uint UintValue
        {
            get
            {
                return uintValue;
            }
            set
            {
                uintValue = value;
                OnPropertyChanged("UintValue");
            }
        }

        public ushort UshortValue
        {
            get
            {
                return ushortValue;
            }
            set
            {
                ushortValue = value;
                OnPropertyChanged("UshortValue");
            }
        }

        public ulong UlongValue
        {
            get
            {
                return ulongValue;
            }
            set
            {
                ulongValue = value;
                OnPropertyChanged("UlongValue");
            }
        }

        public float FloatValue
        {
            get
            {
                return floatValue;
            }
            set
            {
                floatValue = value;
                OnPropertyChanged("FloatValue");
            }
        }

        public double DoubleValue
        {
            get
            {
                return doubleValue;
            }
            set
            {
                doubleValue = value;
                OnPropertyChanged("DoubleValue");
            }
        }

        public decimal DecimalValue
        {
            get
            {
                return decimalValue;
            }
            set
            {
                decimalValue = value;
                OnPropertyChanged("DecimalValue");
            }
        }

        public Size SizeValue
        {
            get
            {
                return sizeValue;
            }
            set
            {
                sizeValue = value;
                OnPropertyChanged("SizeValue");
            }
        }

        public Point PointValue
        {
            get
            {
                return pointValue;
            }
            set
            {
                pointValue = value;
                OnPropertyChanged("PointValue");
            }
        }
        public void ChangeName()
        {
            Name = Guid.NewGuid().ToString();
        }
        
        public void ChangeIntValue()
        {
            IntValue += 1;
        }
        
        public void ChangeShortValue()
        {
            ShortValue += 1;
        }

        public void ChangeLongValue()
        {
            LongValue += 1;
        }

        public void ChangeUintValue()
        {
            UintValue += 1;
        }

        public void ChangeUshortValue()
        {
            UshortValue += 1;
        }

        public void ChangeUlongValue()
        {
            UlongValue += 1;
        }

        public void ChangeFloatValue()
        {
            FloatValue += 1;
        }

        public void ChangeDoubleValue()
        {
            DoubleValue += 1;
        }

        public void ChangeDecimalValue()
        {
            DecimalValue += 1;
        }

        public void ChangePointValue()
        {
            PointValue = new Point(PointValue.X + 1, PointValue.Y + 1);
        }

        public void ChangeSizeValue()
        {
            SizeValue = new Size(SizeValue.Width + 1, SizeValue.Height + 1);
        }

        #endregion

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
