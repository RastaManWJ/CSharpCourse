using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Intermediate
{
    class Stack
    {
        private readonly object[] _stack;
        private int index = 0;
        private readonly int defaultSize = 10;

        public Stack()
        {
            _stack = new object[defaultSize];
        }

        public Stack(int stackSize)
        {
            _stack = new object[stackSize];
        }

        public void Push(object obj)
        {
            if (obj is null)
                throw new InvalidOperationException("You cannot store null objects in stack");
            if (index >= defaultSize)
                throw new IndexOutOfRangeException("Your stack is full!");

            _stack[index] = obj;
            index++;
        }

        public object Pop()
        {
            if (index == 0)
                throw new InvalidOperationException("You cannot pop from empty stack");
            object removedItem = _stack[index - 1];
            _stack[index - 1] = default;
            return removedItem;
        }

        public void Clear()
        {
            for (int i = index; i >= 0; i--)
            {
                _stack[i] = default;
            }
            index = 0;
        }
    }
}
