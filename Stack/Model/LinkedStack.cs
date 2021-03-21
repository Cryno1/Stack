﻿using System;
using System.Collections.Generic;

namespace Stack.Model
{
    public class LinkedStack<T>
    {
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Clear();
        }

        public LinkedStack(T data)
        {
            Set(data);
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {
            if (Count > 0)
            {
                var item = Head;
                Head = Head?.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is Empty");
            }
        }

        public void Set(T data)
        {
           Head = new Item<T>(data);
            Count = 1;
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }


    }
}
