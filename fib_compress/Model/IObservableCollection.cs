using System;
using System.Collections.Generic;
using System.Text;

namespace fib_compress.Model
{
    public interface IObservableCollection<T> : IEnumerable<T>, INotifyCollectionChanged
    { }
}
