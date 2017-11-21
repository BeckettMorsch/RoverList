using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        private int count = 0;
        
        
        public RoverList ()
        {
            head = null;
        }

//        public override int Count => count;
        public override int Count
        {
            get {
                    return count;
                }
        }

        public override void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                current = head;
            }
            else
            {
                // current is the end of the list
                current.Next = new Node(data);
                current = current.Next;
            }
            count++;
        }

        public override void Add(int Position, object data)
        {
            Node next = head;
            Node prev = null;
            // doesn't work
            for(int i=0;i<count;i++)
            {
               if(i==Position)
                {
                    Node node = new Node(data);
                    node.Next = next;
                    if(prev != null)
                    {
                        prev.Next = null;
                    }
                    else
                    {
                        head = node;
                    }
                    count++;
                }
                prev = next;
                if(next.Next != null)
                {
                    next = next.Next;
                }
            }

    
        }

        public override void Clear()
        {
           
            head = null;
            
            count = 0;
        }

        public override Node ElementAt(int Position)
        {
            Node node = head;
            //maybe

            if (Position == 0)
                return node;
            else
            {
                for (int i = 0; i < Position; i++)
                {
                    node = node.Next;
                }
                return node;
            }
        }

        public override void ListNodes()
        {
            Node node = head;
           // if(node== null) { node = node.Next; }
            while (node != null)
            {
                Console.Write(node.Data + " ");

                node = node.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
             Node node = head;


            if (Position == 0)
            {
                node = null;
            }
            else
            {
                for (int i = 0; i < Position - 1; i++)
                {
                    node = node.Next;
                }
                node.Next = node.Next.Next;
            }

             count--;


            return true;



            
        }
    }
}
