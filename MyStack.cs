using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack
    {
        private ElementStack top;
        private int countEl;

        public MyStack()
        {
            countEl = 0;
            top = null;
        }

        public void Push(KeyValuePair<string, string> value)
        {
            countEl++;
            ElementStack el = new ElementStack(value);
            el.Next = top;
            top = el;
        }

        public KeyValuePair<string, string>? Pop()
        {
            if (top == null) return null;

            var value = top.Value;
            top = top.Next;
            countEl--;
            return value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }


}