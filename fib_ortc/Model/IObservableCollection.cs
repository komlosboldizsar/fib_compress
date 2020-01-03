using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{
    public interface IObservableCollection<T> : IEnumerable<T>, INotifyCollectionChanged
    { }
}
