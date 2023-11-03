using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomToolbox
{
    public class NumberBox: System.Windows.Forms.TextBox
    {
        public NumberBox()
        {
            this.KeyPress += NumberBox_KeyPress;
        }

        private void NumberBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
