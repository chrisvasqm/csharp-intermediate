using System.Collections.Generic;
using System.Linq;

namespace udemy_csharp_intermediate.Inheritance
{
    public class Stack
    {
        private readonly List<object> _items = new List<object>();

        public void Push(object obj)
        {
            _items.Add(obj);
        }

        public object Pop()
        {
            var last = _items.Last();
            _items.Remove(last);
            return last;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}