using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASDBFramework.Windows.WinControls
{
    public partial class ASDateTimePicker : DateTimePicker
    {
        public ASDateTimePicker()
        {
            InitializeComponent();
        }

        private void ASDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.CustomFormat = "dd/MM/yyyy";
        }

        private void ASDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Back) || (e.KeyCode==Keys.Delete))
            {
                 this.CustomFormat = " ";
            }
        }
    }
}
