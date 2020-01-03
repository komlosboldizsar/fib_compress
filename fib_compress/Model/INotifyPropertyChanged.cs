using System;
using System.Collections.Generic;
using System.Text;

namespace fib_compress.Model
{

    public delegate void PropertyChangedDelegate(string propertyName);
    public interface INotifyPropertyChanged
    {
        event PropertyChangedDelegate PropertyChanged;
    }

}
