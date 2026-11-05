using System;
using System.Collections.Generic;
using System.Text;

namespace _05._11._26_practic_work_
{
    internal class MathMax
    {
        public static T Max<T>(T a, T b, T c)where T:IComparable<T>
        {
            T max = a;

            if(b.CompareTo(max) > 0)
            {
                max = b;
            }
            if(c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
    }
}
