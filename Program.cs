using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program  
    {
            static void MeasurePerformance()
            {
                int n = 100000; // Кількість елементів для тесту1
                int n2 = 200000; // Кількість елементів для тесту2
                var random = new Random();
                var data = new List<KeyValuePair<string, string>>(n);

                for (int i = 0; i < n; i++)
                {
                    data.Add(new KeyValuePair<string, string>($"key{i}", $"value{i}"));
                }

                // Власний стек
                var myStack = new MyStack();
                var stopwatch = new Stopwatch();

                stopwatch.Start();
                foreach (var item in data)
                {
                    myStack.Push(item);
                }
                stopwatch.Stop();
                Console.WriteLine($"MyStack: Додавання {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                stopwatch.Restart();
                while (!myStack.IsEmpty())
                {
                    myStack.Pop();
                }
                stopwatch.Stop();
                Console.WriteLine($"MyStack: Видалення {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                // Системний неузагальнений стек
                Stack stack = new Stack();
                stopwatch.Restart();
                foreach (var item in data)
                {
                    stack.Push(item);
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Stack: Додавання {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                stopwatch.Restart();
                while (stack.Count > 0)
                {
                    stack.Pop();
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Stack: Видалення {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                // Системний узагальнений стек
                Stack<KeyValuePair<string, string>> genericStack = new Stack<KeyValuePair<string, string>>();
                stopwatch.Restart();
                foreach (var item in data)
                {
                    genericStack.Push(item);
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Stack<T>: Додавання {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                stopwatch.Restart();
                while (genericStack.Count > 0)
                {
                    genericStack.Pop();
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Stack<T>: Видалення {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                // Системна неузагальнена черга
                Queue queue = new Queue();
                stopwatch.Restart();
                foreach (var item in data)
                {
                    queue.Enqueue(item);
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Queue: Додавання {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                stopwatch.Restart();
                while (queue.Count > 0)
                {
                    queue.Dequeue();
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Queue: Видалення {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                // Системна узагальнена черга
                Queue<KeyValuePair<string, string>> genericQueue = new Queue<KeyValuePair<string, string>>();
                stopwatch.Restart();
                foreach (var item in data)
                {
                    genericQueue.Enqueue(item);
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Queue<T>: Додавання {n} елементів = {stopwatch.ElapsedMilliseconds} мс");

                stopwatch.Restart();
                while (genericQueue.Count > 0)
                {
                    genericQueue.Dequeue();
                }
                stopwatch.Stop();
                Console.WriteLine($"System.Queue<T>: Видалення {n} елементів = {stopwatch.ElapsedMilliseconds} мс");
            }

            static void Main(string[] args)
            {
                MeasurePerformance();
            }
        }.
}
