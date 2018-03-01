using System;
using System.Windows.Forms;

namespace Billing_System.Utility
{
    class commonutility
    {

        public void checkIsStringOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void checkBothDS(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public void checkIsDigitOrNot(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
