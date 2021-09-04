using System;
using System.Collections.Generic;
namespace queue
{
    class Program
    {
        static void Main(string[] args)

        {
            //FIFO(FIRST IN FIRST OUT)
            Queue<string> names = new Queue<string>();
            names.Enqueue("Asma");
            names.Enqueue("Ashu");
            names.Enqueue("Sana");
            names.Enqueue("Ashu");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}
