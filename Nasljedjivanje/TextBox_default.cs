using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextBox_default : TextBox
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
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }

        private void DrawDefaultText(Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.Left);
        }
        public string defaultText = "DefaultText";
    }
}
