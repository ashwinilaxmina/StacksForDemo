
namespace StacksForDemo
{
    public class ArrayStack
    {
        private int[] stackArray;

        private int stackSize;

        private int count;

        public ArrayStack(int size)
        {
            stackSize = size;
            stackArray = new int[size];
        }

        public void Push(int item)
        {
            stackArray[count] = item;
            count++;
        }

        public int Pop()
        {
            return stackArray[--count];
        }

        public int Peek()
        {
            return stackArray[count - 1];
        }
    }
}
