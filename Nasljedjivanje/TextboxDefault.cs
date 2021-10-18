using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasljeđivanje
{
    class TextboxDefault : TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(TextLength == 0)
            {
                DrawDefaultText(e.Graphics);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if(TextLength == 0)
            {
                Invalidate();
            }
        }

        private void DrawDefaultText(System.Drawing.Graphics graphics)
        {
            TextRenderer.DrawText(graphics, defaultText, Font, this.Bounds, System.Drawing.Color.Black, System.Drawing.Color.White);
        }

        private string defaultText = "Default text";
    }
}
