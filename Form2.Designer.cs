namespace cis285finalproject
{
    partial class Form2
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
            this.frmccnquad1 = new System.Windows.Forms.TextBox();
            this.frmccnquad4 = new System.Windows.Forms.TextBox();
            this.frmccnquad3 = new System.Windows.Forms.TextBox();
            this.frmccnquad2 = new System.Windows.Forms.TextBox();
            this.txtsecinfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmccnquad1
            // 
            this.frmccnquad1.Location = new System.Drawing.Point(12, 9);
            this.frmccnquad1.Name = "frmccnquad1";
            this.frmccnquad1.Size = new System.Drawing.Size(100, 31);
            this.frmccnquad1.TabIndex = 0;
            // 
            // frmccnquad4
            // 
            this.frmccnquad4.Location = new System.Drawing.Point(12, 120);
            this.frmccnquad4.Name = "frmccnquad4";
            this.frmccnquad4.Size = new System.Drawing.Size(100, 31);
            this.frmccnquad4.TabIndex = 1;
            // 
            // frmccnquad3
            // 
            this.frmccnquad3.Location = new System.Drawing.Point(12, 83);
            this.frmccnquad3.Name = "frmccnquad3";
            this.frmccnquad3.Size = new System.Drawing.Size(100, 31);
            this.frmccnquad3.TabIndex = 2;
            // 
            // frmccnquad2
            // 
            this.frmccnquad2.Location = new System.Drawing.Point(12, 46);
            this.frmccnquad2.Name = "frmccnquad2";
            this.frmccnquad2.Size = new System.Drawing.Size(100, 31);
            this.frmccnquad2.TabIndex = 3;
            // 
            // txtsecinfo
            // 
            this.txtsecinfo.AutoSize = true;
            this.txtsecinfo.Location = new System.Drawing.Point(118, 15);
            this.txtsecinfo.Name = "txtsecinfo";
            this.txtsecinfo.Size = new System.Drawing.Size(236, 100);
            this.txtsecinfo.TabIndex = 4;
            this.txtsecinfo.Text = "for security reasons\r\n please reenter the \r\n4 parts of your CCN \r\ninto the boxes " +
    "provided";
            this.txtsecinfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "btnconfirm2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsecinfo);
            this.Controls.Add(this.frmccnquad2);
            this.Controls.Add(this.frmccnquad3);
            this.Controls.Add(this.frmccnquad4);
            this.Controls.Add(this.frmccnquad1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frmccnquad1;
        private System.Windows.Forms.TextBox frmccnquad4;
        private System.Windows.Forms.TextBox frmccnquad3;
        private System.Windows.Forms.TextBox frmccnquad2;
        private System.Windows.Forms.Label txtsecinfo;
        private System.Windows.Forms.Button button1;
    }
}