namespace cis285finalproject
{
    partial class Form5
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
            this.txtducks = new System.Windows.Forms.Label();
            this.frmducks = new System.Windows.Forms.TextBox();
            this.btnducksclose = new System.Windows.Forms.Button();
            this.btnduckssubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtducks
            // 
            this.txtducks.AutoSize = true;
            this.txtducks.Location = new System.Drawing.Point(12, 9);
            this.txtducks.Name = "txtducks";
            this.txtducks.Size = new System.Drawing.Size(194, 39);
            this.txtducks.TabIndex = 0;
            this.txtducks.Text = "For security reasons\r\n please input a country (real or fictional) \r\nthat you thin" +
    "k should have more ducks";
            // 
            // frmducks
            // 
            this.frmducks.Location = new System.Drawing.Point(12, 51);
            this.frmducks.Name = "frmducks";
            this.frmducks.Size = new System.Drawing.Size(194, 20);
            this.frmducks.TabIndex = 1;
            // 
            // btnducksclose
            // 
            this.btnducksclose.Location = new System.Drawing.Point(12, 77);
            this.btnducksclose.Name = "btnducksclose";
            this.btnducksclose.Size = new System.Drawing.Size(75, 23);
            this.btnducksclose.TabIndex = 2;
            this.btnducksclose.Text = "close";
            this.btnducksclose.UseVisualStyleBackColor = true;
            this.btnducksclose.Click += new System.EventHandler(this.btnducksclose_Click);
            // 
            // btnduckssubmit
            // 
            this.btnduckssubmit.Location = new System.Drawing.Point(131, 77);
            this.btnduckssubmit.Name = "btnduckssubmit";
            this.btnduckssubmit.Size = new System.Drawing.Size(75, 23);
            this.btnduckssubmit.TabIndex = 3;
            this.btnduckssubmit.Text = "submit";
            this.btnduckssubmit.UseVisualStyleBackColor = true;
            this.btnduckssubmit.Click += new System.EventHandler(this.btnduckssubmit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 181);
            this.Controls.Add(this.btnduckssubmit);
            this.Controls.Add(this.btnducksclose);
            this.Controls.Add(this.frmducks);
            this.Controls.Add(this.txtducks);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtducks;
        private System.Windows.Forms.TextBox frmducks;
        private System.Windows.Forms.Button btnducksclose;
        private System.Windows.Forms.Button btnduckssubmit;
    }
}