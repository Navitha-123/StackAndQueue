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
            Console.WriteLine("choose option 1.pushstack \t 2.Popandpeek element");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
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
                default:
                    Console.WriteLine("Enter wrong choice");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}
