using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class UC4Dequeuequeuecreation
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
                //front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
            //  Console.WriteLine(data+ "inserted to queue");
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

        //Dequeue method
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("queue is empty");
            }
            Console.WriteLine("{0} is deleted from the queue", front.data);
            front = front.next;
        }

        public void IsEmpty()
        {
            while(front != null)
            {
                Dequeue();
                Console.WriteLine();
                IsEmpty();
                Console.WriteLine();
            }
        }
    }
}
