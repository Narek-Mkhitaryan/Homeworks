using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Homework_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Create a list of integers and add 5 elements to it.
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

 //--------------------------------------------------------------------------------------------------
 //Create a dictionary with string keys and integer values, and add 5 key-value pairs to it.
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Apple", 1);
            dictionary.Add("Banana", 2);
            dictionary.Add("Cherry", 3);
            dictionary.Add("Date", 4);
            dictionary.Add("Elderberry", 5);

//--------------------------------------------------------------------------------------------------
//Create a queue of integers and add 5 elements to it.
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

//--------------------------------------------------------------------------------------------------
//Create a stack of integers and add 5 elements to it.
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

//--------------------------------------------------------------------------------------------------
        }
    }
}
