using System;

namespace StackClassImplementation
{
class LinkedNode<T>
    {
        public T Data { get; set; }
        public LinkedNode<T> Next { get; set; }
	
        public LinkedNode()
        {
            Data = default(T);
            Next = null;
        }
	
        public LinkedNode(T data)
        {
            Data = data;
            Next = null;
        }
	
        public LinkedNode(T data, LinkedNode<T> next)
        {
            Data = data;
            Next = next;
        }
    }
}
