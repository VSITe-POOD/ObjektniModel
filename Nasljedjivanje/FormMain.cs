using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Nasljeđivanje
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                if (tb.TextLength == 0)
                {
                    TextRenderer.DrawText(tb.CreateGraphics(), "Default value", tb.Font, tb.ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
                }
            }
        }
    }
}
