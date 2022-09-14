using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.pushstack \t 2.Popandpeek element \t 3.Enqueue operation  \t 4.Dequeueoperation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UC1PushStackElements stack = new UC1PushStackElements();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    Uc2PopStackElements stack1 = new Uc2PopStackElements();
                    stack1.Push(70);
                    stack1.Push(30);
                    stack1.Push(56);
                    stack1.IsEmpty();
                    stack1.Display();
                    break;
                case 3:
                    UC3EnqueueQueueCreation queue = new UC3EnqueueQueueCreation();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                case 4:
                    UC4Dequeuequeuecreation queue1 = new UC4Dequeuequeuecreation();
                    queue1.Enqueue(56);
                    queue1.Enqueue(30);
                    queue1.Enqueue(70);
                    queue1.Dequeue();
                    queue1.IsEmpty();
                  
                    queue1.Display();
                    break;

                    Console.ReadLine();
            }
        }
    }
}
