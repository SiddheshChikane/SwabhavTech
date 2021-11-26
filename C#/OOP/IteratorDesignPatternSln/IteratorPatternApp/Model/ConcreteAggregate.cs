using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternApp.Model
{
    class ConcreteAggregate : IAggregate
    {
        List<object> items = new List<object>();
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public object this[int index]
        {
            set
            {
                items.Insert(index, value);
            }
            get
            {
                return items[index];
            }
        }
    }
}
