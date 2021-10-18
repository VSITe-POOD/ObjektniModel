namespace Nasljeđivanje
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxDefault = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.Label();
            this.textBoxDefault1 = new Nasljeđivanje.TextBoxDefault();
            this.textBox2 = new TextBoxDefault();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TextBoxDefault
            // 
            this.TextBoxDefault.AutoSize = true;
            this.TextBoxDefault.Location = new System.Drawing.Point(49, 19);
            this.TextBoxDefault.Name = "TextBoxDefault";
            this.TextBoxDefault.Size = new System.Drawing.Size(80, 13);
            this.TextBoxDefault.TabIndex = 2;
            this.TextBoxDefault.Text = "TextBoxDefault";
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Location = new System.Drawing.Point(52, 64);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(46, 13);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "TextBox";
            // 
            // textBoxDefault1
            // 
            this.textBoxDefault1.Location = new System.Drawing.Point(178, 13);
            this.textBoxDefault1.Name = "textBoxDefault1";
            this.textBoxDefault1.Size = new System.Drawing.Size(136, 20);
            this.textBoxDefault1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(457, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.TextBoxDefault);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxDefault1);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxDefault textBoxDefault1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TextBoxDefault;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}

