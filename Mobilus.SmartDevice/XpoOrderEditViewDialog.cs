using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mobilus.SmartDevice
{
    public partial class XpoOrderEditViewDialog : Form
    {
        public XpoOrderEditViewDialog()
        {
            InitializeComponent();
        }

        private void XpoOrderEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.xpoOrderBindingSource.EndEdit();

        }
    }
}