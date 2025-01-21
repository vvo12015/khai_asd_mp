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
        public ElementStack next;

        public string Value { get; }

        public ElementStack(string v)
        {
            Value = v;
        }
    };
        
}
