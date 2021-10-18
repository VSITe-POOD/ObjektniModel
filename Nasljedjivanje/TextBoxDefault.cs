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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
                DrawDefaultText(e.Graphics);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }
        private void DrawDefaultText(System.Drawing.Graphics g)
        {
            TextRenderer.DrawText(g, defaultText, Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);

        }
        public string DefaultText
        {
            get { return defaultText;  }
            set { defaultText = value; }
        }
        private string defaultText = "Default value";
    }
}
