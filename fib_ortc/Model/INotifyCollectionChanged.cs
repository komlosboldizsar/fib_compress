using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{

    public delegate void CollectionChangedDelegate();
    public interface INotifyCollectionChanged
    {
        event CollectionChangedDelegate CollectionChanged;
    }

}
