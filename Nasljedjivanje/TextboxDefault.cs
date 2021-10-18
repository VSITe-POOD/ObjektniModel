using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Nasljeđivanje
{
    class TextboxDefault : TextBox
    {
        
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength==0);
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
            DrawDefaultText(e.Graphics);
        }
        private void DrawDefaultText(System.Drawing.Graphics graphics)
        {
            
            TextRenderer.DrawText(graphics,defaultText,Font, ClientRectangle,SystemColors.GrayText,TextFormatFlags.TextBoxControl);
        }
        public String DefaultText
        {
            get { return defaultText; }
            set { defaultText = value; }
        }
        private String defaultText = "Default text";
    }
}
