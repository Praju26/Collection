using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class Stackdemo
    {

         public Stackdemo()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            Console.WriteLine($"Element on top of stack is: {stack.Peek()}");

            IEnumerator<int> enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }

            Console.WriteLine($"\n\nPopping element: {stack.Pop()}");
            int poppedElement;
            stack.TryPop(out poppedElement);
            Console.WriteLine($"\nTrying to pop element: {poppedElement}");
            Console.WriteLine($"\nTotal Count: {stack.Count}");
            Console.WriteLine($"\nDoes stack have 5? {stack.Contains(5)}");
        }


    }
}
