namespace cis285finalproject
{
    partial class Form4
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
            this.frmnicemessage = new System.Windows.Forms.TextBox();
            this.txtnicemessagebox = new System.Windows.Forms.Label();
            this.btnnicemessageclose = new System.Windows.Forms.Button();
            this.btnnicemessagesubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmnicemessage
            // 
            this.frmnicemessage.Location = new System.Drawing.Point(30, 31);
            this.frmnicemessage.MinimumSize = new System.Drawing.Size(531, 250);
            this.frmnicemessage.Multiline = true;
            this.frmnicemessage.Name = "frmnicemessage";
            this.frmnicemessage.Size = new System.Drawing.Size(531, 250);
            this.frmnicemessage.TabIndex = 0;
            // 
            // txtnicemessagebox
            // 
            this.txtnicemessagebox.AutoSize = true;
            this.txtnicemessagebox.Location = new System.Drawing.Point(208, 9);
            this.txtnicemessagebox.Name = "txtnicemessagebox";
            this.txtnicemessagebox.Size = new System.Drawing.Size(153, 13);
            this.txtnicemessagebox.TabIndex = 1;
            this.txtnicemessagebox.Text = "Input your nice message below";
            // 
            // btnnicemessageclose
            // 
            this.btnnicemessageclose.Location = new System.Drawing.Point(108, 287);
            this.btnnicemessageclose.Name = "btnnicemessageclose";
            this.btnnicemessageclose.Size = new System.Drawing.Size(114, 53);
            this.btnnicemessageclose.TabIndex = 2;
            this.btnnicemessageclose.Text = "close";
            this.btnnicemessageclose.UseVisualStyleBackColor = true;
            this.btnnicemessageclose.Click += new System.EventHandler(this.btnnicemessageclose_Click);
            // 
            // btnnicemessagesubmit
            // 
            this.btnnicemessagesubmit.Location = new System.Drawing.Point(373, 287);
            this.btnnicemessagesubmit.Name = "btnnicemessagesubmit";
            this.btnnicemessagesubmit.Size = new System.Drawing.Size(113, 53);
            this.btnnicemessagesubmit.TabIndex = 3;
            this.btnnicemessagesubmit.Text = "submit";
            this.btnnicemessagesubmit.UseVisualStyleBackColor = true;
            this.btnnicemessagesubmit.Click += new System.EventHandler(this.btnnicemessagesubmit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 352);
            this.Controls.Add(this.btnnicemessagesubmit);
            this.Controls.Add(this.btnnicemessageclose);
            this.Controls.Add(this.txtnicemessagebox);
            this.Controls.Add(this.frmnicemessage);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frmnicemessage;
        private System.Windows.Forms.Label txtnicemessagebox;
        private System.Windows.Forms.Button btnnicemessageclose;
        private System.Windows.Forms.Button btnnicemessagesubmit;
    }
}