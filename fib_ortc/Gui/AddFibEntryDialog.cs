using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fib_ortc.Gui
{
    public partial class AddFibEntryDialog : Form
    {
        public AddFibEntryDialog()
        {
            InitializeComponent();
        }

        public string Prefix => prefixTextBox.Text;

        public string NextHop => nextHopTextBox.Text;

    }
}
