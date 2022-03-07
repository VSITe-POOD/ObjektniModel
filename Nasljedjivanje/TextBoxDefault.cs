using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    public class TextBoxDefault : TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, this.TextLength == 0);
        }

        private string defaultText = "Default";
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.Text.Length == 0)
            {
                DrawDefaultText(e.Graphics);
            }

        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, this.TextLength == 0);
            Invalidate();
        }

        private void DrawDefaultText(Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, this.Font, this.ClientRectangle, SystemColors.GrayText, TextFormatFlags.Left);
        }
    }
}