using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{

    public delegate void PropertyChangedDelegate(string propertyName);
    public interface INotifyPropertyChanged
    {
        event PropertyChangedDelegate PropertyChanged;
    }

}
