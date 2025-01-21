using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyStack
    {
        class MyStack
        {
            public ElementStack top;

            int countEl;

            MyStack()
            {
                countEl = 0;
            }

            void push(string value)
            {
                countEl++;
                ElementStack el = new ElementStack(value);
                el.next = top;
                top = el;
            }

            void pop()
            {
                if (countEl == 0) return;
                countEl--;
                if (top != null)
                {
                    ElementStack temp = top;
                    top = top.next;
                }
            }

            string toString()
            {
                ElementStack cEl = top;
                string result;
                int i = 0;
                while (cEl != null)
                {
                    std::format_to(
                    std::back_inserter(result),
                    "{} - {},\n",
                    to_string(i++), cEl->value
                    );
                    cEl = cEl->next;
                }
                return result;
            }

            float peek()
            {
                return top->value;
            }

            float min()
            {
                ElementStack* cEl = top;
                float min = cEl->value;
                while (cEl != nullptr)
                {
                    if (cEl->value < min)
                    {
                        min = cEl->value;
                    }
                    cEl = cEl->next;
                }
                return min;
            }
        };

        void fullStack(ElementStack& stack)
        {

            for (int i = 0; i < 100; i++)
            {
                int value = rand() % 10;
                stack.push(value);
            }

        };

    }
}
}
