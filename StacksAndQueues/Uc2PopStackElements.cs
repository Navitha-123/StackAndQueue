using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Uc2PopStackElements
    {
        Node top;
        public void Push(int data) 
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                newNode.next = null;
            }
            else 
            {
                newNode.next = top;
            }
            top = newNode;
        }


        public void Display() 
        {
            if (top == null)
                Console.WriteLine("stack is empty");

            while (top != null)
            {
                Console.WriteLine(" " + top.data + " ");
                top = top.next;
            }

        }

        public void Peek()
        {

            if (this.top == null)
                Console.WriteLine("stack is empty");

            Console.WriteLine("{0} is on the top of stack", this.top.data);
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("satck is empty");
            }
            Console.WriteLine("{0} is deleted element of stack", top.data);
        }
        public void IsEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Console.WriteLine();
                Pop();
                Console.WriteLine();
            }
            Display();
        }


    }
}
