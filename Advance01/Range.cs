using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance01
{
    internal class Range<T> where T : IComparable<T>
    {

        public T Minimum { get; }
        public T Maximum { get; }


        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum should be less than or equal to Maximum.");
            }
            Minimum = minimum;
            Maximum = maximum;
        }
        public bool Contains(T value)
        {
            return (Minimum.CompareTo(value) <= 0) && (Maximum.CompareTo(value) >= 0);
        }

    }
}
