using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ElementStack
    {
        public KeyValuePair<string, string> Value { get; }
        public ElementStack Next { get; set; }

        public ElementStack(KeyValuePair<string, string> value)
        {
            Value = value;
        }
    }

}
