using LottoClassLibrary.Numbers;
using LottoClassLibrary.Numbers.Abstract;
using LottoClassLibrary.Rows.Abstract;
using System;
using System.Text;

namespace LottoClassLibrary.Rows
{
    public class VikingRow : Row
    {
        public VikingRow()
        {
            RowNumbers = new Number[RowLength];
            Number temp;
            for (int i = 0; i < RowLength - 1;)
            {
                temp = new VikingNormalNumber();
                if (!NumberExists(temp))
                {
                    RowNumbers[i] = temp;
                    i++;
                }
            }
            Array.Sort(RowNumbers, 0, RowLength-1);
            RowNumbers[6] = new VikingSpecialNumber();
        }

        public override string ToString()
        {
            StringBuilder str = new();
            for (int i = 0; i < RowLength; i++)
            {
                str.Append(RowNumbers[i]);
                if (i == RowLength - 2) str.Append('-');
                else if (i < RowLength - 1) str.Append(' ');

            }
            return str.ToString();
        }
    }
}
