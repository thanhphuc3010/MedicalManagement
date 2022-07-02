using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagement.Helper
{
    public static class ControlExtensions
    {
        public static void Disable(this Control control)
        {
            control.Enabled = false;
        }
      
        public static void Enable(this Control control)
        {
            control.Enabled = true;
        }

        public static void FormatCurrency(this Control control, decimal value)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            control.Text = value.ToString("c", culture);
        }
    }
}
