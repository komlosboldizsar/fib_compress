using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fib_compress.Gui
{
    public partial class DoLookupDialog : Form
    {
        public DoLookupDialog()
        {
            InitializeComponent();
        }

        public string IP => ipAddressTextBox.Text;

    }
}
