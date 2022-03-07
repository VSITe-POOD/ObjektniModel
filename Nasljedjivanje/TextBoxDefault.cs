using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e.Graphics);
            }
        }

        private void DrawDefaultText(Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, this.Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.Left);
        }

        private string defaultText = "Default";
    }
}
