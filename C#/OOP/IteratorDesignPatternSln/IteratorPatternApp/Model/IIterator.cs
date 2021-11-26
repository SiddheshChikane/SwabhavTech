using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternApp.Model
{
    public interface IIterator
    {
        object First();
        object Next();
        object CurrentItem();

    }
}