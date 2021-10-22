using LottoClassLibrary.Numbers;
using LottoClassLibrary.Numbers.Abstract;
using LottoClassLibrary.Rows.Abstract;
using System;
using System.Text;

namespace LottoClassLibrary.Rows
{
    public class JokerRow : Row
    {
        public JokerRow()
        {
            RowNumbers = new Number[RowLength];
            for (int i = 0; i < RowLength; i++)
            {
                RowNumbers[i] = new JokerNumber();
            }
            Array.Sort(RowNumbers);
        }

        public override string ToString()
        {
            StringBuilder str = new();
            for (int i = 0; i < RowLength; i++)
            {
                str.Append(RowNumbers[i]);
                if (i < RowLength - 1) str.Append(' ');
            }
            return str.ToString();
        }
    }
}
