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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string rtnnicemessage { get; set; }
        private void btnnicemessageclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnicemessagesubmit_Click(object sender, EventArgs e)
        {
            //aaa
            this.rtnnicemessage = frmnicemessage.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
