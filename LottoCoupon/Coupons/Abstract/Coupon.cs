using LottoClassLibrary.Rows;
using LottoClassLibrary.Rows.Abstract;
using System;
using System.Text;

namespace LottoClassLibrary.Coupons.Abstract
{
    public abstract class Coupon
    {
        public Row[] Rows;
        public Row[] JokerRows;
        public int RowMaxCount { get => 10; }

        public void AddJokers()
        {
            JokerRows = new JokerRow[2];
            for (int i = 0; i <= 1; i++)
            {
                JokerRows[i] = new JokerRow();
            }
        }

        public bool RowExists(Row other)
        {
            if (other == null) throw new NullReferenceException();
            for (int i = 0; i < Rows.Length; i++)
            {
                if (Rows[i] != null && Rows[i].Equals(other)) return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            for (int i = 0; i < Rows.Length; i++)
            {
                str.AppendLine($"{Rows[i]}");
            }

            if (JokerRows != null)
            {
                str.AppendLine(new string('-', 20));
                for (int i = 0; i < JokerRows.Length; i++)
                {
                    str.AppendLine($"{JokerRows[i]}");
                }
            }
            return str.ToString();
        }
    }
}
