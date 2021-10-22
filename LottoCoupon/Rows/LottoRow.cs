using LottoClassLibrary.Numbers;
using LottoClassLibrary.Numbers.Abstract;
using LottoClassLibrary.Rows.Abstract;
using System;
using System.Text;

namespace LottoClassLibrary.Rows
{
    public class LottoRow : Row
    {
        public LottoRow()
        {
            RowNumbers = new Number[RowLength];
            Number temp;
            for (int i = 0; i < RowLength;)
            {
                temp = new LottoNumber();
                if (!NumberExists(temp))
                {
                    RowNumbers[i] = temp;
                    i++;
                }
            }
            Array.Sort(RowNumbers);
        }

        public override string ToString()
        {
            StringBuilder str = new();
            for (int i = 0; i < RowLength; i++)
            {
                str.Append(RowNumbers[i]);
                if (i < RowLength-1) str.Append(' ');
            }
            return str.ToString();
        }
    }
}
