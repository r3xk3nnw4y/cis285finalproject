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
    public partial class Form3 : Form
    {

        public string rtnsecsum { get; set; }
        public string rtnsecprod { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.rtnsecprod = frmsecprod.Text;
            this.rtnsecsum = frmsecsum.Text;
            if ( !CustomerMaintenance.Validator.IsDigitsOnly(rtnsecprod))
            {
                //aaa
                MessageBox.Show("Please enter a valid credit card number");
            }
            else if (!CustomerMaintenance.Validator.IsDigitsOnly(rtnsecsum))
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
