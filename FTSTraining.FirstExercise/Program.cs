namespace FTSTraining.FirstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t \t ----------\t\twelcome To Stack Implementation Exercise!\t\t---------");
            // test #1. Stack with int type. 
            Stack<int> stack1 = new Stack<int>();
            int[] arr1 = { 3, 4, 5 };
            StaticTest(stack1, arr1);

            // test #2. Stack with double type. 
            Stack<double> stack2 = new Stack<double>();
            double[] arr2 = { 3.5, 4.5, 5.5 };
            StaticTest(stack2, arr2);

            // test #1. Stack with string type. 
            Stack<string> stack3 = new Stack<string>();
            string[] arr3 = { "Alaa", "Zuhd", "FTS" };
            StaticTest(stack3, arr3);

        }

        public static void StaticTest<T>(Stack<T> stack, T[] items_arr)
        {
            Console.WriteLine($"Testing Stack<{typeof(T).Name}> will start.");

            Console.Write("Items to be pushed into the stack are: "); 
            foreach(T item in items_arr) { Console.Write($"{item}, "); }
            Console.WriteLine("");

            // push array items into the stack
            foreach(T item in items_arr) { stack.Push(item); }
            Console.WriteLine("Items were pushed into the stack");
            // display the stack content 
            stack.Print();
            // remove one item from the stakc 
            T? top_item = stack.Pop();
            Console.WriteLine($"One Item was removed from the stack using Pop(), removed item: {top_item}");
            // display the content of the stakc again: the last item will be noticed that it was removed. 
            stack.Print();
            // now get the top item from the stack. 
            top_item = stack.Peek();
            Console.WriteLine($"The top item in the stack is: {top_item}");
            // clear the stack 
            stack.Clear();
            // trying to print the stack content but stakc is emmpty.
            Console.WriteLine("Trying to display the stack items. However the stack is empty (It was cleared)"); 
            stack.Print();
            // try to pop one more item from the stack (stak is empty so as appropiate msg will be displayed)
            Console.WriteLine("Trying to pop the last item from the stack, However the stack is empty!"); 
            top_item = stack.Pop();
            // the same thing will be displayed when trying to get the last item from the stack when it's empty.
            Console.WriteLine("Trying to get the peak item from the stack. However the stack is empty!");
            top_item = stack.Peek();
            Console.WriteLine("Test is completed.");
            Console.WriteLine("\t \t ----------\t\t----------\t\t----------\n");
        }
    }
}