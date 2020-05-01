using Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public class SpecialString
    {
        public string Value { get; }

        public SpecialString(string str)
        {
            Value = str;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
