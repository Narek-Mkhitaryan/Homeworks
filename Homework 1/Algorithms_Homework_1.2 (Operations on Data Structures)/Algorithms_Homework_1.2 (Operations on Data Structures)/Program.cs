using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Homework_1._2__Operations_on_Data_Structures_
{
    internal class Program
    {
        static void Main(string[] args)
        {
//--------------------------------------------------------------------------------------------------
//Calculate and print the sum of all elements in the list.
            int count = 0;
            List<int> list = new List<int>(){1, 2, 3, 4, 5};
            for (int i = 0; i <= list.Count; i++)
            {
                count = count + i;
            }
            Console.WriteLine(count);
//--------------------------------------------------------------------------------------------------
//Calculate and print the sum of all values in the dictionary.

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Apple", 1);
            dictionary.Add("Banana", 2);
            dictionary.Add("Cherry", 3);
            dictionary.Add("Date", 4);
            dictionary.Add("Elderberry", 5);

            int sum = 0;
            foreach (var i in dictionary)
            {
                sum +=  + i.Value;
            }
            Console.WriteLine(sum);

//--------------------------------------------------------------------------------------------------
//Remove 2 elements from the queue and print the remaining elements.

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            
            foreach (var item in queue) 
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

//--------------------------------------------------------------------------------------------------
//Remove 2 elements from the stack and print the remaining elements.
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
//--------------------------------------------------------------------------------------------------
        }
    }
}
