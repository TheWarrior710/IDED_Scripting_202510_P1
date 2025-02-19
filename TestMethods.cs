using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
       
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            foreach (uint number in stack) 
            {
                if (IsPrime(number)) 
                {
                    return number; 
                }
            }
            return 0; 
        }

        
        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> tempStack = new Stack<uint>(); 
            bool removed = false;

            while (stack.Count > 0)
            {
                uint current = stack.Pop(); 
                if (!removed && IsPrime(current))
                {
                    removed = true; 
                    continue; 
                }
                tempStack.Push(current); 
            }

            
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

            return stack;
        }

        
        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> queue = new Queue<uint>();

           
            foreach (uint number in stack)
            {
                queue.Enqueue(number);
            }

            return queue;
        }

     
        internal static List<uint> StackToList(Stack<uint> stack)
        {
            List<uint> list = new List<uint>();

            foreach (uint number in stack)
            {
                list.Add(number);
            }

            return list;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            
            int n = list.Count;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {

                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped); 

           
            foreach (int num in list)
            {
                if (num == value)
                {
                    return true;
                }
            }

            return false;
        }

        
        private static bool IsPrime(uint number)
        {
            if (number < 2)
                return false;

            for (uint i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

    }
}