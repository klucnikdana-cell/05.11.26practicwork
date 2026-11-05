using System;
using System.Collections.Generic;
using System.Text;

namespace _05._11._26_practic_work_
{
    internal class MathMin
    {
        public static T Min<T>(T a1, T b1, T c1) where T : IComparable<T>
        {
            T min = a1;

            if (b1.CompareTo(min) < 0)
            {
                min = b1;
            }
            if (c1.CompareTo(min) < 0)
            {
                min = c1;
            }
            return min;
        }
    }
}
