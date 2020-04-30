using Lists;
using System;

namespace Project
{
    public static class Extensions
    {
        public static SpecialString ToSpecialString(this string str)
        {
            return new SpecialString(str);
        }
    }
}
