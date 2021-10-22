using System;

namespace LottoClassLibrary.Numbers.Abstract
{
    public abstract class Number : IComparable<Number>
    {
        protected static Random rnd = new();
        public int No { get; set; }

        public int CompareTo(Number other)
        {
            if (other == null) throw new NullReferenceException();
            return No.CompareTo(other.No);
        }

        public override string ToString()
        {
            return string.Format($"{No}").PadLeft(2, '0');
        }
    }
}
