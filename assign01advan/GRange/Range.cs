using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign01advan.GRange
{
    internal class Range<T>  where T : IComparable<T>
    {
        #region Attribute
        public T Start { get; set; }
        public T End { get; set; }
        #endregion

        #region constructor 
        public Range(T start, T end)
        {
            Start = start;
            End = end;
        }
        #endregion

        #region CompareTo
        public int CompareTo(Range<T> other)
        {
            if (Start.CompareTo(other.Start) == 0)
            {
                return End.CompareTo(other.End);
            }
            return Start.CompareTo(other.Start);
        }
        #endregion

        #region IsInRange
        public bool IsInRange(T value)
        {
            return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
        }

        #endregion

        #region Length
        public double Length()
        {
            if (Convert.ToDouble(End) - Convert.ToDouble(Start) < 0)
                return (Convert.ToDouble(End) - Convert.ToDouble(Start) * (-1));
            return Convert.ToDouble(End) - Convert.ToDouble(Start);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"Start : {Start} , End : {End}";
        } 
        #endregion
    }
}
