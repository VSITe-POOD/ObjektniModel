using System;
using System.Collections.Generic;
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
                DrawDefaultText(e.Graphics);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (TextLength == 0)
                Invalidate();
        }

        private void DrawDefaultText(System.Drawing.Graphics g)
        {
            TextBoxRenderer.DrawTextBox(g, ClientRectangle, defaultText, Font, System.Windows.Forms.VisualStyles.TextBoxState.Normal);
        }

        private string defaultText = "Default";
    }
}
