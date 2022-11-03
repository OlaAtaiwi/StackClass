using System;
using System.Collections.Generic;
using System.Text;
/*
 this file  includes 3  implementations for Stack Class
(the last 2 are commented)
 */
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
    public class Stack<T>
    {
        public int Count { get; private set; }
        private LinkedNode<T> top;
	
        public Stack()
        {
            Count = 0;

        }

        public void Push(T item)
        {
            LinkedNode<T> addedItem = new LinkedNode<T>(item);
            if (top == null)
                top = addedItem;
            else
            {
                addedItem.Next = top;
                top = addedItem;

            }
            Count++;
        }
	
        public T Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Empty Stack");
            T topItem = top.Data;
            top = top.Next;
            Count--;
            return topItem;
        }

        public void Print()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("Stack Items: ");
            LinkedNode<T> temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine("______________________________");
        }
	
        public T Peak()
        {
            if (top == null)
                throw new InvalidOperationException("Empty Stack");
            T topItem = top.Data;
            return topItem;


        }
	
        public void Clear()
        {
            top = null;
            Count = 0;
        }
    }
}
//Based on array
/*
  public class Stack<T>
    {
        private  T[] _items;
        private int _currentIndex = -1;
        private int size = 10;
        public Stack() => _items = new T[size];
        public int Count => _currentIndex + 1;
        public void Push(T item) 
        {
            if (Count ==size)
            { 
                int newSize = size * 2;
                T[] newItems = new T[newSize];
                _items.CopyTo(newItems, 0);
                _items = newItems;
                size = newSize;
            }    
           
            
             _items[++_currentIndex] = item; 
            
        }
        public T Pop()
        {
            if (_currentIndex > -1)
               return _items[_currentIndex--];
             else throw new InvalidOperationException("Empty Stack");
        }
        public void Print() 
        {
	    Console.WriteLine("______________________________");
            Console.WriteLine("Stack Items: ");
            for(int i= 0;i <= _currentIndex;i++)
            {
                Console.WriteLine(_items[i]);
            }
	     Console.WriteLine("______________________________");
        }
        public T Peak() 
        {
            if (Count > 0)
                return _items[_currentIndex];
            else
                throw new InvalidOperationException("Empty Stack");   
        }
        public void Clear() => _currentIndex = -1;
        
    }
 
 */

//Based on LinkedList Class 

/*
 public class Stack<T>
    {
       private LinkedList<T> _items;
        public Stack()
        {
            _items = new LinkedList<T>();
        }
        public void Push(T item) 
        {
            _items.AddFirst(item);
        }
        public T Pop()
        {
            if(_items.Count==0)
                throw new InvalidOperationException("Empty Stack");
            T top = _items.First.Value;
            _items.RemoveFirst();
            return top;
        }
        public void Print()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("Stack Items: ");
            foreach (T item in _items)
                Console.WriteLine(item);
            Console.WriteLine("______________________________");
        }
        public T Peak()
        {
            if(_items.Count==0)
                throw new InvalidOperationException("Empty Stack");
            return _items.First.Value;
        }
        public void Clear()
        {
            _items.Clear();
        }
    }
 */

