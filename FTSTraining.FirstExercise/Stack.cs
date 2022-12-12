using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTSTraining.FirstExercise
{
    // generic Stack class. 
    public class Stack<T>
    {


        List<T> stack = new List<T>();

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T? Pop()
        {
            if(stack.Count > 0)
            {
                T item = stack.Last();
                stack.RemoveAt(stack.Count - 1); 
                return item;    
            } 
            else
            {
                Console.WriteLine("Stack is empty.");
                return default(T); 
            }
        }

        public T? Peak()
        {
            if (stack.Count > 0)
            {
                return stack.Last();
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return default(T);
            }
        }

        public void Print()
        {
            if (stack.Count > 0)
            {
                Console.WriteLine("Stack items are: ");
                for (int i = 0; i < stack.Count; i++)
                {
                    Console.Write($"Stack[{i}]: {stack[i]}\t");
                }
                Console.WriteLine("");
            } else
            {
                Console.WriteLine("Stack is Empty.");
            }
        }

        public void Clear()
        {
            if (stack.Count == 0)
                Console.WriteLine("Stack is already Empty.");
            else
            {
                while (stack.Count > 0)
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                Console.WriteLine("Stack was cleared... Stack is empty now.");
            }
        }

    }
}
