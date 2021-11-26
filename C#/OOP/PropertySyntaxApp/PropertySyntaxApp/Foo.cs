using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp
{
    class Foo
    {
        private int _bar;
        private int _baz;

        public Foo()
        {
            Random Rand_num = new Random();
            _baz = Rand_num.Next(0, 100);
        }
        public int Baz
        {
            get
            {
                return _baz;
            }
        }
        public int Bar
        {
            get
            {
                return _bar;
            }
            set
            {
                if(value > 0)
                {
                    _bar = value;
                }
            }
        }
    }
}
