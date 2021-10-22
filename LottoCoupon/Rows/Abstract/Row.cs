using LottoClassLibrary.Numbers.Abstract;
using System;

namespace LottoClassLibrary.Rows.Abstract
{
    public abstract class Row
    {
        public Number[] RowNumbers;
        public virtual int RowLength { get => 7; }

        public bool NumberExists(Number otherNum)
        {
            for (int i = 0; i < RowLength; i++)
            {

                if (RowNumbers[i] == null) return false;
                else if(RowNumbers[i].CompareTo(otherNum) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object other)
        {
            if (other == null) throw new NullReferenceException();
            Row otherRow = other as Row;
            int c = 0;
            for (int i = 0; i < RowLength; i++)
            {
                if (otherRow.RowNumbers[i].No == RowNumbers[i].No) c++;
            }
            if (c == RowLength - 1) return true;
            return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
