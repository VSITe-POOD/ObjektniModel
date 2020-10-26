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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Adressa = new System.Windows.Forms.Label();
            this.textBoxAdressa = new TextBoxDefault();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i Prezime";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // Adressa
            // 
            this.Adressa.AutoSize = true;
            this.Adressa.Location = new System.Drawing.Point(12, 48);
            this.Adressa.Name = "Adressa";
            this.Adressa.Size = new System.Drawing.Size(45, 13);
            this.Adressa.TabIndex = 2;
            this.Adressa.Text = "Adressa";
            // 
            // textBoxAdressa
            // 
            this.textBoxAdressa.Location = new System.Drawing.Point(15, 64);
            this.textBoxAdressa.Name = "textBoxAdressa";
            this.textBoxAdressa.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdressa.TabIndex = 3;
           // this.textBoxAdressa.TextChanged += new System.EventHandler(this.textBoxAdressa_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 164);
            this.Controls.Add(this.textBoxAdressa);
            this.Controls.Add(this.Adressa);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label Adressa;
        private System.Windows.Forms.TextBox textBoxAdressa;
    }
}

