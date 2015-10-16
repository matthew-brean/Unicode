namespace Unicode
{
    partial class Form1
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
            this.lstUnicode = new System.Windows.Forms.ListBox();
            this.btnShowUnicode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUnicode
            // 
            this.lstUnicode.FormattingEnabled = true;
            this.lstUnicode.Location = new System.Drawing.Point(46, 112);
            this.lstUnicode.Name = "lstUnicode";
            this.lstUnicode.Size = new System.Drawing.Size(120, 95);
            this.lstUnicode.TabIndex = 0;
            // 
            // btnShowUnicode
            // 
            this.btnShowUnicode.Location = new System.Drawing.Point(55, 71);
            this.btnShowUnicode.Name = "btnShowUnicode";
            this.btnShowUnicode.Size = new System.Drawing.Size(99, 23);
            this.btnShowUnicode.TabIndex = 1;
            this.btnShowUnicode.Text = "Show Unicode";
            this.btnShowUnicode.UseVisualStyleBackColor = true;
            this.btnShowUnicode.Click += new System.EventHandler(this.btnShowUnicode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowUnicode);
            this.Controls.Add(this.lstUnicode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnicode;
        private System.Windows.Forms.Button btnShowUnicode;
    }
}

