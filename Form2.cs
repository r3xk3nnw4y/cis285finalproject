using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cis285finalproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string rtnccnquad1 { get; set; }
        public string rtnccnquad2 { get; set; }
        public string rtnccnquad3 { get; set; }
        public string rtnccnquad4 { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rtnccnquad1 = frmccnquad1.Text;
            this.rtnccnquad2 = frmccnquad2.Text;
            this.rtnccnquad3 = frmccnquad3.Text;
            this.rtnccnquad4 = frmccnquad4.Text;
            if (rtnccnquad1.Length != 4 || !CustomerMaintenance.Validator.IsDigitsOnly(rtnccnquad1))
            {
                //aaa
                MessageBox.Show("Please enter a valid credit card number");
            }
            else if (rtnccnquad2.Length != 4 || !CustomerMaintenance.Validator.IsDigitsOnly(rtnccnquad2))
            {
                //aaa
                MessageBox.Show("Please enter a valid credit card number");
            }
            else if (rtnccnquad3.Length != 4 || !CustomerMaintenance.Validator.IsDigitsOnly(rtnccnquad3))
            {
                //aaa
                MessageBox.Show("Please enter a valid credit card number");
            }
            else if (rtnccnquad4.Length != 4 || !CustomerMaintenance.Validator.IsDigitsOnly(rtnccnquad4))
            {
                //aaa
                MessageBox.Show("Please enter a valid credit card number");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
