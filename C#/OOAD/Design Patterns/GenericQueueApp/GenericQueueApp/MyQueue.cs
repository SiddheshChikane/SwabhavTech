using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    public class MyQueue<T>:IQueue<T>
    {
        public LinkedList<T> _itemList = new LinkedList<T>();


        public int Count()
        {
            return _itemList.Count();
        }

        public T Deque()
        {
            this._itemList.RemoveFirst();
            return _itemList.First();
        }

        public void Enque(T item)
        {
            this._itemList.AddLast(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _itemList.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _itemList.GetEnumerator();
        }
    }
}
