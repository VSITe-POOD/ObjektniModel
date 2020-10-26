using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    
    class TextBoxDefault : TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }
        private string defaultText = "defaultText";
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
                DrawDefaultText(e.Graphics);
        }
        protected void DrawDefaultText(Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }
    }
}


