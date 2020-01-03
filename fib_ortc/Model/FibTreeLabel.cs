using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{

    public class FibTreeLabel : INotifyPropertyChanged
    {

        public event PropertyChangedDelegate PropertyChanged;

        private string text;

        public string Text
        {
            get => text;
            set
            {
                if (value == text)
                    return;
                text = value;
                PropertyChanged?.Invoke(nameof(Text));
            }
        }

        private string nextHop;

        public string NextHop
        {
            get => nextHop;
            set
            {
                if (value == nextHop)
                    return;
                nextHop = value;
                PropertyChanged?.Invoke(nameof(NextHop));
            }
        }

        public FibTreeLabel(string text, string nextHop)
        {
            this.text = text;
            this.nextHop = nextHop;
        }

    }

}
