
using System.Drawing;
namespace OX.Strongbind.Tests
{
    public interface IBusinessObject
    {
        string Name { get; set; }
        int IntValue { get; set; }
        short ShortValue { get; set; }
        long LongValue { get; set; }
        uint UintValue { get; set; }
        ushort UshortValue { get; set; }
        ulong UlongValue { get; set; }
        float FloatValue { get; set; }
        double DoubleValue { get; set; }
        decimal DecimalValue { get; set; }
        //Point PointValue { get; set; }
        //Size SizeValue { get; set; }

        void ChangeName();
        void ChangeIntValue();
        void ChangeShortValue();
        void ChangeLongValue();
        void ChangeUintValue();
        void ChangeUshortValue();
        void ChangeUlongValue();
        void ChangeFloatValue();
        void ChangeDoubleValue();
        void ChangeDecimalValue();
        //void ChangePointValue();
        //void ChangeSizeValue();
    }
}
