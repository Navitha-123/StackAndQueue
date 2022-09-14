using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class UC1PushStackElements
    {
        Node top;//top is variable of node type

        public void Push(int data) //method of push
        {
            Node newNode = new Node(data);
            if (top == null)// check top is null or not
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
    }
}
