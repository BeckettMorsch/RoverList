﻿using System;
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
           
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override Node ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            Node node = head;

            while (node != null)
            {
                Console.Write(node.Data + " ");

                node = node.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            Node node = head;

            // Debug.Assert(Position < count, "Index out of bounds");
            if (Position < 0 || Position >= count)
                throw new IndexOutOfRangeException();

            for(int i=0;i<Position;i++)
            {
                node = node.Next;
            }
            node = null;

            count--;
            return true;
        }
    }
}
