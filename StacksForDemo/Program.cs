namespace StacksForDemo
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            ArrayStack integerStack = new ArrayStack(10);

            integerStack.Push(2);
            integerStack.Push(4);
            Console.WriteLine(integerStack.Peek());
            Console.WriteLine(integerStack.Pop());
            Console.WriteLine(integerStack.Pop());
            Console.ReadLine();
        }
    }
}
