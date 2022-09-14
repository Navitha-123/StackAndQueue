using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class UC3EnqueueQueueCreation
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (rear == null)
            {
                rear = newNode;
                front = rear;
                
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("queue is empty");
            }
            while (front != null)
            {
                Console.WriteLine(front.data);
                front = front.next;
            }
        }
    }
}
