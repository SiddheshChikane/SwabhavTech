using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternApp.Model
{
    class ConcreteIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public object First()
        {
            return _aggregate[0];
        }

        public object Next()
        {
            object r = null;
            if (_current < _aggregate.Count-1)
            {
                r = _aggregate[++_current];
            }
            return r;
        }

        public object CurrentItem()
        {
            return _aggregate[_current];
        }
    }
}
