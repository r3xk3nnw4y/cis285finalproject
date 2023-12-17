namespace cis285finalproject
{
    partial class Form3
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
            this.frmsecsum = new System.Windows.Forms.TextBox();
            this.frmsecprod = new System.Windows.Forms.TextBox();
            this.txtpinsum = new System.Windows.Forms.Label();
            this.txtpinprod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubmit3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmsecsum
            // 
            this.frmsecsum.Location = new System.Drawing.Point(106, 120);
            this.frmsecsum.Name = "frmsecsum";
            this.frmsecsum.Size = new System.Drawing.Size(100, 31);
            this.frmsecsum.TabIndex = 0;
            // 
            // frmsecprod
            // 
            this.frmsecprod.Location = new System.Drawing.Point(106, 160);
            this.frmsecprod.Name = "frmsecprod";
            this.frmsecprod.Size = new System.Drawing.Size(100, 31);
            this.frmsecprod.TabIndex = 1;
            // 
            // txtpinsum
            // 
            this.txtpinsum.AutoSize = true;
            this.txtpinsum.Location = new System.Drawing.Point(16, 126);
            this.txtpinsum.Name = "txtpinsum";
            this.txtpinsum.Size = new System.Drawing.Size(52, 25);
            this.txtpinsum.TabIndex = 2;
            this.txtpinsum.Text = "sum";
            // 
            // txtpinprod
            // 
            this.txtpinprod.AutoSize = true;
            this.txtpinprod.Location = new System.Drawing.Point(16, 160);
            this.txtpinprod.Name = "txtpinprod";
            this.txtpinprod.Size = new System.Drawing.Size(84, 25);
            this.txtpinprod.TabIndex = 3;
            this.txtpinprod.Text = "product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 100);
            this.label3.TabIndex = 4;
            this.label3.Text = "For security reasons \r\nplease input the sum\r\n and product of the digits \r\nof your" +
    " secuirty pin ";
            // 
            // btnsubmit3
            // 
            this.btnsubmit3.Location = new System.Drawing.Point(106, 197);
            this.btnsubmit3.Name = "btnsubmit3";
            this.btnsubmit3.Size = new System.Drawing.Size(115, 44);
            this.btnsubmit3.TabIndex = 5;
            this.btnsubmit3.Text = "submit";
            this.btnsubmit3.UseVisualStyleBackColor = true;
            this.btnsubmit3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 259);
            this.Controls.Add(this.btnsubmit3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpinprod);
            this.Controls.Add(this.txtpinsum);
            this.Controls.Add(this.frmsecprod);
            this.Controls.Add(this.frmsecsum);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frmsecsum;
        private System.Windows.Forms.TextBox frmsecprod;
        private System.Windows.Forms.Label txtpinsum;
        private System.Windows.Forms.Label txtpinprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsubmit3;
    }
}