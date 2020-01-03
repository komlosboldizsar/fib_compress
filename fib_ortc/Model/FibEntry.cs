using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{

    public class FibEntry : INotifyPropertyChanged
    {

        public event PropertyChangedDelegate PropertyChanged;

        private string binaryForm = "";

        public string BinaryForm
        {
            get => binaryForm;
            set
            {
                if (value == binaryForm)
                    return;
                binaryForm = value;
                PropertyChanged?.Invoke(nameof(BinaryForm));
                PropertyChanged?.Invoke(nameof(IpForm));
            }
        }

        public string IpForm
        {
            get => PrefixConverter.BinaryToIp(binaryForm);
            set
            {
                BinaryForm = PrefixConverter.IpToBinary(value);
            }
        }

        private int PrefixLength => binaryForm.Length;

        private string nextHop = "";

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

        public FibEntry(string binaryForm, string nextHop)
        {
            BinaryForm = binaryForm;
            NextHop = nextHop;
        }

        public FibEntry(string ipForm, string nextHop, object _ipFormUnused)
        {
            IpForm = ipForm;
            NextHop = nextHop;
        }

    }
}
