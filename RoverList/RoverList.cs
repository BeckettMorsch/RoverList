using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        int c = 0;
        
        
        public RoverList ()
        {
            head = null;
        }

        public override int Count
        {
            get {
                    return c;
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
            c++;
        }

        public override void Add(int Position, object data)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
