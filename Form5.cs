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
    public partial class Form5 : Form
    {
        public string rtnducks { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void btnduckssubmit_Click(object sender, EventArgs e)
        {
            this.rtnducks = frmducks.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnducksclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
