using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RectpackSharp;
using CustomerMaintenance;
using System.Runtime.CompilerServices;

namespace cis285finalproject
{
    public partial class Form1 : Form
    {
        public string strpin = "";
        public string stremail1 = "";
        public string strccn1 = "";
        public string strfirstname = "";
        public string strlastname = "";
        public string strbilladdress = "";
        public string strexpirdate = "";
        public string stremail2 = "";
        public DateTime daydelidatestart;
        public string strradcatchoice = "";
        public string strradbrandchoice = "";
        public string strradamountchoice = "";
        public string stryutin = "";
        public string strywater = "";
        public string strydayhour = "";
        public string stryzodiac = "";
        public string strrutin = "";
        public string strrwater = "";
        public string strrdayhour = "";
        public string strrzodiac = "";
        public string strnicemessage = "";
        public bool boothoughts = false;
        public bool booprayers = false;
        public bool boobestwishes = false;
        public bool booworstwishes = false;
        public bool boodumpling = false;
        public Random rnd = new Random();
        //PackingRectangle[] rectanglestest = new PackingRectangle[5];
        public List<Control> lstcontrols1 = new List<Control>();
        public List<PackingRectangle[]> lstrectcontrols3 = new List<PackingRectangle[]>();
        public List<List<Control>> lstcontrols2 = new List<List<Control>>();
        public List<PackingRectangle[]> lstrectcontrols4 = new List<PackingRectangle[]>();
        PackingRectangle[] rectanglestest = new PackingRectangle[5];
        public Control.ControlCollection controlll;
        OpenFileDialog fildiaprettypicture = new OpenFileDialog();
        //public List<Control> lstcontrols1 = new List<Control>();
        //System.Windows.Forms.AutoScaleMode.Dpi;

        //public clsloc loctest;
        clsloc loctest = new clsloc();
        //loctest.xval=0;
        //car myObj = new car();
        //myObj.color = 2;

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
            //bwForm.RunWorkerAsync();
            //var list = new List<Control> { };
            var textboxes = this.Controls.OfType<Control>();
            //MessageBox.Show("weird");
            lstcontrols1 = textboxes.ToList();
            //MessageBox.Show(lstcontrols1[5].Name);
            //MessageBox.Show(textboxes[5].name);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //myObj.color = 2;
            loctest.xval = 0;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)//this is supposed to be chkprettypicture, dont know why its not updating
        {
            if (chkpicture.Enabled == true)
            {
                //MessageBox.Show("ping");

                fildiaprettypicture.Title = "select pretty picture";
                fildiaprettypicture.ShowDialog();
                txtfirstname.Text = fildiaprettypicture.FileName;
                memebox.ImageLocation = fildiaprettypicture.FileName;
                this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
                Rectangle boundstest = frmfirstname.Bounds;


                //boundstest.
                //MessageBox.Show(bounds);
                //rectanglestest[1].

            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radcategory1_CheckedChanged(object sender, EventArgs e)
        {
            if (radcategory1.Checked)
            {
                //aaa
                radbrand1.Text = "Walmart";
                radbrand2.Text = "Target";
                radbrand3.Text = "Publix";
                radbrand1.Checked = false;
                radbrand2.Checked = false;
                radbrand3.Checked = false;
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;
            }
        }

        private void radcategory2_CheckedChanged(object sender, EventArgs e)
        {
            if (radcategory2.Checked)
            {
                //aaa
                radbrand1.Text = "The North Face";
                radbrand2.Text = "Scottevest";
                radbrand3.Text = "L.L.Bean";
                radbrand1.Checked = false;
                radbrand2.Checked = false;
                radbrand3.Checked = false;
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;
            }
        }

        private void radcategory3_CheckedChanged(object sender, EventArgs e)
        {
            if (radcategory3.Checked)
            {
                //aaa
                radbrand1.Text = "Starbucks";
                radbrand2.Text = "Burger King";
                radbrand3.Text = "Tim Hortons";
                radbrand1.Checked = false;
                radbrand2.Checked = false;
                radbrand3.Checked = false;
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;
            }
        }

        private void radcategory4_CheckedChanged(object sender, EventArgs e)
        {
            if (radcategory4.Checked)
            {
                //aaa
                radbrand1.Text = "Thrift shops";
                radbrand2.Text = "Steam";
                radbrand3.Text = "The Fae";
                radbrand1.Checked = false;
                radbrand2.Checked = false;
                radbrand3.Checked = false;
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;
            }
        }

        private void radbrand1_CheckedChanged(object sender, EventArgs e)
        {
            radamount1.Text = "$10";
            radamount2.Text = "$50";
            radamount3.Text = "$100";
            radamount1.Checked = false;
            radamount2.Checked = false;
            radamount3.Checked = false;
        }

        private void radbrand2_CheckedChanged(object sender, EventArgs e)
        {
            radamount1.Text = "$20";
            radamount2.Text = "$63";
            radamount3.Text = "$114";
            radamount1.Checked = false;
            radamount2.Checked = false;
            radamount3.Checked = false;
        }

        private void radbrand3_CheckedChanged(object sender, EventArgs e)
        {
            string msg = "";
            timer2.Enabled = false;
            if (radbrand3.Text == "The Fae")
            {
                radamount1.Text = "Teeth";
                radamount2.Text = "Femurs";
                radamount3.Text = "Ribs";
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;
                if(radbrand3.Checked)
                {
                    msg = "All of our suppliers with The Fae have met with a terrible fate. please select a different brand.";
                }
               
            }
            else
            {
                radamount1.Text = "$18";
                radamount2.Text = "$57";
                radamount3.Text = "$108";
                radamount1.Checked = false;
                radamount2.Checked = false;
                radamount3.Checked = false;

            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void grpamount_Enter(object sender, EventArgs e)
        {
            caldelidate1.Visible = true;
            txtdelidate1.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            strfirstname = frmfirstname.Text;
            strlastname = frmlastname.Text;
            stremail1 = frmyouremail.Text;
            stremail1 = stremail1.ToLower();
            strbilladdress = frmbilladdress.Text;
            strccn1 = frmccn.Text;
            strccn1 = CustomerMaintenance.Validator.ReplaceWhitespace(strccn1, "");
            strpin = frmpin.Text;
            strexpirdate = frmexpirdate.Text;
            strexpirdate = strexpirdate.ToLower();
            strexpirdate = CustomerMaintenance.Validator.removeslash(strexpirdate, "");
            stremail2 = frmrepemail.Text;
            stremail2 = stremail2.ToLower();
            daydelidatestart = caldelidate1.SelectionStart.Date;
            //MessageBox.Show(strpin[1]);
            /*string strccnpiece1 = strccn1.Remove(4);
            string strccnpiece2 = strccn1.Remove(0, 4).Remove(4);
            string strccnpiece3 = strccn1.Remove(0, 8).Remove(4);
            string strccnpiece4 = strccn1.Remove(0, 12);
            MessageBox.Show(strccnpiece1 + " " + strccnpiece2 + " " + strccnpiece3 + " " + strccnpiece4);
            */

            RadioButton radioBtn = this.grpcategory.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radcategory1":
                        strradcatchoice = radcategory1.Text;
                        break;

                    case "radcategory2":
                        strradcatchoice = radcategory2.Text;
                        break;

                    case "radcategory3":
                        strradcatchoice = radcategory3.Text;
                        break;
                }
            }
            radioBtn = this.grpbrand.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radbrand1":
                        strradbrandchoice = radbrand1.Text;
                        break;

                    case "radbrand2":
                        strradbrandchoice = radbrand2.Text;
                        break;

                    case "radbrand3":
                        strradbrandchoice = radbrand3.Text;
                        break;
                }
            }
            radioBtn = this.grpamount.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radamount1":
                        strradamountchoice = radamount1.Text;
                        break;

                    case "radamount2":
                        strradamountchoice = radamount2.Text;
                        break;

                    case "radamount3":
                        strradamountchoice = radamount3.Text;
                        break;
                    case "radamount4":
                        strradamountchoice = frmamount4.Text;
                        break;
                }
            }
            //MessageBox.Show(strradcatchoice + " " + strradbrandchoice + " " + strradamountchoice);
            //MessageBox.Show(caldelidate1.TodayDate.Ticks.ToString());
            //MessageBox.Show(longdelidatestart.ToString());
            inputchecker();



        }
        int inputchecker()
        {
            string msg = "";
            //MessageBox.Show(strccn1);

            if (msg == "")
            {
                radpage1.Checked = true;
                msg += CustomerMaintenance.Validator.IsPresent(strfirstname, txtfirstname.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strlastname, txtlastname.Text);
                msg += CustomerMaintenance.Validator.IsPresent(stremail1, txtyouremail.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strbilladdress, txtbilladdress.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strccn1, txtccn.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strpin, txtpin.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strexpirdate, txtexpirdate.Text);
                msg += CustomerMaintenance.Validator.IsPresent(stremail2, txtrepemail.Text);
                radpage2.Checked = true;
                msg += CustomerMaintenance.Validator.IsPresent(stryutin, txtfirstname.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strrutin, txtlastname.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strywater, txtyouremail.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strrwater, txtbilladdress.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strydayhour, txtccn.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strrdayhour, txtpin.Text);
                msg += CustomerMaintenance.Validator.IsPresent(stryzodiac, txtexpirdate.Text);
                msg += CustomerMaintenance.Validator.IsPresent(strrzodiac, txtrepemail.Text);

            }
            // yes I could use msg += to make an incredibly long list of everything wrong with it and drop that into the same message box.
            // its intentionally designed to only give you one error at a time because its more in line with the password game that way.
            // also because i think its funnier that way. 

            if (msg == "")
            {
                msg = CustomerMaintenance.Validator.IsValidEmail(stremail1, txtrepemail.Text);
            }

            if (msg == "")
            {
                if (stremail1.IndexOf("@tutanota.") == -1 && stremail1.IndexOf("@tuta.") == -1 && stremail1.IndexOf("@zoho.") == -1)
                {
                    //aaa
                    msg = "We're sorry we are only allowing email addresses from Tutanota or Zoho currently, please use a compatible email address.";
                }
            }
            if (msg == "")
            {
                msg = CustomerMaintenance.Validator.IsValidEmail(stremail2, txtrepemail.Text);
            }

            if (msg == "")
            {
                if (stremail2.IndexOf("@tutanota.") == -1 && stremail2.IndexOf("@tuta.") == -1 && stremail2.IndexOf("@zoho.") == -1)
                {
                    //aaa
                    msg = "We're sorry we are only allowing email addresses from Tutanota or Zoho currently, please use a compatible email address.";
                }
            }

            if (msg == "")
            {
                if (strccn1.Length != 16 || !CustomerMaintenance.Validator.IsDigitsOnly(strccn1))
                {
                    //aaa
                    msg = "Please enter a valid credit card number";
                }
            }

            if (msg == "")
            {
                if (daydelidatestart != caldelidate1.SelectionEnd.Date)
                {
                    //aaa
                    msg = "Please select just one day to deliver the gift Card";
                }
            }

            if (msg == "")
            {
                if (daydelidatestart < caldelidate1.TodayDate.Date)
                {
                    //aaa
                    msg = "We have yet to discover how to travel faster than light or create a Flux Capacitor, as such we cannot travel back in time. Please select a day in the future.";
                }
            }

            if (msg == "")
            {
                if (strpin.Length != 3 || !CustomerMaintenance.Validator.IsDigitsOnly(strpin))
                {
                    //aaa
                    msg = "Please enter a valid Security code";
                }
            }

            if (msg == "")
            {
                if (strexpirdate.Length != 4)
                {
                    //aaa
                    msg = "please enter a valid expiration date";
                }
                else if (Convert.ToInt32(strexpirdate.Remove(2)) > 12 || Convert.ToInt32(strexpirdate.Remove(0, 2)) < 23)
                {
                    msg = "Please enter a valid expiration date.";
                }
            }

            if (msg == "")
            {
                if (strradamountchoice == "The fae")
                {
                    //aaa
                    msg = "All of our suppliers with The Fae have met with a terrible fate. please select a different brand.";
                }
            }


            if (msg != "")
            {
                MessageBox.Show(msg);
                return 1;
            }
            else
            {
                return 0;
            }
            //aaa
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //strfirstname = frmfirstname.Text;
            //strlastname = frmlastname.Text;
            //stremail1 = frmyouremail.Text;
            //stremail1 = stremail1.ToLower();
            //strbilladdress = frmbilladdress.Text;
            //strccn1 = frmccn.Text;
            //strccn1 = CustomerMaintenance.Validator.ReplaceWhitespace(strccn1, "");
            //strpin = frmpin.Text;
            //strexpirdate = frmexpirdate.Text;
            //strexpirdate = strexpirdate.ToLower();
            //strexpirdate = CustomerMaintenance.Validator.removeslash(strexpirdate, "");
            //stremail2 = frmrepemail.Text;
            //stremail2 = stremail2.ToLower();
            //daydelidatestart = caldelidate1.SelectionStart.Date;
            //MessageBox.Show(strpin[1]);
            /*string strccnpiece1 = strccn1.Remove(4);
            string strccnpiece2 = strccn1.Remove(0, 4).Remove(4);
            string strccnpiece3 = strccn1.Remove(0, 8).Remove(4);
            string strccnpiece4 = strccn1.Remove(0, 12);
            MessageBox.Show(strccnpiece1 + " " + strccnpiece2 + " " + strccnpiece3 + " " + strccnpiece4);
            */

            RadioButton radioBtn = this.grpcategory.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radcategory1":
                        strradcatchoice = radcategory1.Text;
                        break;

                    case "radcategory2":
                        strradcatchoice = radcategory2.Text;
                        break;

                    case "radcategory3":
                        strradcatchoice = radcategory3.Text;
                        break;
                }
            }
            radioBtn = this.grpbrand.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radbrand1":
                        strradbrandchoice = radbrand1.Text;
                        break;

                    case "radbrand2":
                        strradbrandchoice = radbrand2.Text;
                        break;

                    case "radbrand3":
                        strradbrandchoice = radbrand3.Text;
                        break;
                }
            }
            radioBtn = this.grpamount.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radamount1":
                        strradamountchoice = radamount1.Text;
                        break;

                    case "radamount2":
                        strradamountchoice = radamount2.Text;
                        break;

                    case "radamount3":
                        strradamountchoice = radamount3.Text;
                        break;
                    case "radamount4":
                        strradamountchoice = frmamount4.Text;
                        break;
                }
            }
            if (inputchecker() == 1)
            {
                return;
            }
            //aaa
            using (var boxform2 = new Form2())
            {
                var result = boxform2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string strval1 = boxform2.rtnccnquad1;            //values preserved after close
                    string strval2 = boxform2.rtnccnquad2;
                    string strval3 = boxform2.rtnccnquad3;            //values preserved after close
                    string strval4 = boxform2.rtnccnquad4;
                    string strccnpiece1 = strccn1.Remove(4);
                    string strccnpiece2 = strccn1.Remove(0, 4).Remove(4);
                    string strccnpiece3 = strccn1.Remove(0, 8).Remove(4);
                    string strccnpiece4 = strccn1.Remove(0, 12);
                    if (strval1 != strccnpiece1 || strval2 != strccnpiece2 || strval3 != strccnpiece3 || strval4 != strccnpiece4)
                    {
                        MessageBox.Show("Credit Card Number does not match");
                        return;
                    }
                    //Convert.ToInt32(strexpirdate.Remove(0, 2)) < 23

                    //Do something here with these values

                    //for example
                    //this.txtSomething.Text = val;
                }
            }

            using (var boxform3 = new Form3())
            {
                var result = boxform3.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int intval1 = Convert.ToInt32(boxform3.rtnsecsum);
                    int intval2 = Convert.ToInt32(boxform3.rtnsecprod);
                    int intsecprod = (strpin[0] - '0') * (strpin[1] - '0') * (strpin[2] - '0');
                    int intsecsum = (strpin[0] - '0') + (strpin[1] - '0') + (strpin[2] - '0');
                    if (intval1 != intsecsum || intval2 != intsecprod)
                    {
                        MessageBox.Show("Security PIN could not be confirmed");
                        return;
                    }
                    else
                    {
                        
                    }

                }
            }

            using (var boxform5 = new Form5())
            {
                var result = boxform5.ShowDialog();
                if (result == DialogResult.OK)
                {
                    strnicemessage = boxform5.rtnducks;            //values preserved after close
                }
            }
            MessageBox.Show("gift card successfully sent.");
        }

        private void radpage1_CheckedChanged(object sender, EventArgs e)
        {

            txtfirstname.Text = "First Name";
            frmfirstname.Location = new Point(78, 25);
            frmfirstname.Size = new Size(116, 31);
            frmfirstname.Text = strfirstname;

            txtlastname.Text = "Last Name";
            frmlastname.Location = new Point(78, 48);
            frmlastname.Size = new Size(116, 31);
            frmlastname.Text = strlastname;

            txtyouremail.Text = "your email";
            frmyouremail.Location = new Point(78, 71);
            frmyouremail.Size = new Size(116, 31);
            frmyouremail.Text = stremail1;

            txtbilladdress.Text = "Billing Address";
            frmbilladdress.Location = new Point(98, 94);
            frmbilladdress.Size = new Size(97, 31);
            frmbilladdress.Text = strbilladdress;

            txtccn.Text = "CCN";
            frmccn.Location = new Point(49, 117);
            frmccn.Size = new Size(146, 31);
            frmccn.Text = strccn1;

            txtpin.Text = "Security PIN";
            frmpin.Location = new Point(143, 140);
            frmpin.Size = new Size(52, 31);
            frmpin.Text = strpin;

            txtexpirdate.Text = "Expiration Date";
            frmexpirdate.Location = new Point(143, 160);
            frmexpirdate.Size = new Size(52, 31);
            frmexpirdate.Text = strexpirdate;

            txtrepemail.Text = "Recipients Email";
            frmrepemail.Location = new Point(108, 180);
            frmrepemail.Size = new Size(87, 31);
            frmrepemail.Text = stremail2;
            if (boodumpling)
            {
                dumplingattack();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e) //this is apparently radpage2, i dont why it doesnt match, but somehow it works
        {
            //put dumpling attack here

            txtfirstname.Text = "Your favorite kitchen utensil";
            frmfirstname.Location = new Point(155, 25);
            frmfirstname.Size = new Size(39, 30);
            frmfirstname.Text = stryutin;

            txtlastname.Text = "rec. favorite kitchen utensil";
            frmlastname.Location = new Point(155, 45);
            frmlastname.Size = new Size(39, 30);
            frmlastname.Text = strrutin;

            txtyouremail.Text = "your favorite brand of water";
            frmyouremail.Location = new Point(155, 74);
            frmyouremail.Size = new Size(39, 30);
            frmyouremail.Text = strywater;

            txtbilladdress.Text = "rec. favorite brand of water";
            frmbilladdress.Location = new Point(155, 95);
            frmbilladdress.Size = new Size(39, 30);
            frmbilladdress.Text = strrwater;

            txtccn.Text = "your most annoying day hour";
            frmccn.Location = new Point(159, 117);
            frmccn.Size = new Size(35, 20);
            frmccn.Text = strydayhour;

            txtpin.Text = "rec. most annoying day hour";
            frmpin.Location = new Point(159, 142);
            frmpin.Size = new Size(35, 20);
            frmpin.Text = strrdayhour;

            txtexpirdate.Text = "your zodiac sign";
            frmexpirdate.Location = new Point(99, 161);
            frmexpirdate.Size = new Size(95, 20);
            frmexpirdate.Text = stryzodiac;

            txtrepemail.Text = "rec. zodiac sign";
            frmrepemail.Location = new Point(99, 180);
            frmrepemail.Size = new Size(95, 20);
            frmrepemail.Text = strrzodiac;

            if (boodumpling)
            {
                dumplingattack();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            prgbar1.Visible = true;
            if (prgbar1.Visible && prgbar1.Value < prgbar1.Maximum && prgbar1.Value > prgbar1.Minimum)
            {
                if (prgbar1.Value - 100 > prgbar1.Minimum)
                {
                    prgbar1.Value = prgbar1.Value - 100;
                }
                else
                {
                    prgbar1.Value = prgbar1.Minimum;
                }

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            // Your DoConvert code here
            // ...
            prgbar1.Visible = true;
            int percent = 0;

            //prgbar1.Value = 0;
            while (true)
            {
                percent = percent + 1;
                bgw.ReportProgress(percent);
                //prgbar1.Value= prgbar1.Value+100;

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'e')
            {
                //do something
                //MessageBox.Show("you pressed ee");
                //memebox.Image =
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //good one use it
        {
            if (prgbar1.Visible == true)
            {
                switch (keyData)
                {
                    case Keys.E:
                        //MessageBox.Show("you pressed e"); //this is the right one use this.

                        string exeFile = (new System.Uri(Assembly.GetEntryAssembly().Location)).AbsolutePath;
                        string exeDir = Path.GetDirectoryName(exeFile);
                        string fullpath = Path.Combine(exeDir, "..\\..\\..\\Resources\\imge.jpg");
                        memebox.ImageLocation = fullpath;
                        this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case Keys.A:
                        break;
                        for (int i = 0; i < lstcontrols1.Count; i++)
                        {
                            rectanglestest[i].Id = i;
                            rectanglestest[i].X = ((uint)lstcontrols1[i].Location.X);
                            rectanglestest[i].Y = ((uint)lstcontrols1[i].Location.Y);
                            rectanglestest[i].Width = ((uint)lstcontrols1[i].Width);
                            rectanglestest[i].Height = ((uint)lstcontrols1[i].Height);
                        }
                        break;
                    default:
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void BwForm_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (prgbar1.Value < prgbar1.Maximum)
            {
                this.prgbar1.Value = e.ProgressPercentage;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string msg = "";
            prgbar1.Visible = true;
            prgbar1.Value += 10;
            if (prgbar1.Value == prgbar1.Maximum)
            {
                this.Close();
            }
            if (!boodumpling)
            {
                if (grppage.Visible == true && rnd.Next(1, 10000) + (prgbar1.Value) > 12500)
                {
                    dumplingattack();
                }
            }
            else
            {
                if (grppage.Visible == true && rnd.Next(1, 10000) > 9990)
                {
                    dumplingattack();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string msg = "";
            if (radpage2.Checked == false)
            {


                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strfirstname, txtfirstname.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strlastname, txtlastname.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(stremail1, txtyouremail.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strbilladdress, txtbilladdress.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strccn1, txtccn.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strpin, txtpin.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strexpirdate, txtexpirdate.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(stremail2, txtrepemail.Text);
                }
            }
            if (radpage2.Checked == true)
            {
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(stryutin, txtfirstname.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strrutin, txtlastname.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strywater, txtyouremail.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strrwater, txtbilladdress.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strydayhour, txtccn.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strrdayhour, txtpin.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(stryzodiac, txtexpirdate.Text);
                }
                if (msg == "")
                {
                    msg += CustomerMaintenance.Validator.IsPresent(strrzodiac, txtrepemail.Text);
                }
            }
            txtinfobox.Text = msg;

        }

        private void frmfirstname_TextChanged(object sender, EventArgs e)
        {
            string msg = "";
            timer2.Enabled = false;
            //put firstname update box code here 
            if (radpage2.Checked == false)
            {
                strfirstname = frmfirstname.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(strfirstname, txtfirstname.Text);
            }
            else if (radpage2.Checked == true)
            {
                stryutin = frmfirstname.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void frmlastname_TextChanged(object sender, EventArgs e)
        {
            string msg = "";
            timer2.Enabled = false;
            if (radpage2.Checked == false)
            {
                strlastname = frmlastname.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(strlastname, txtlastname.Text);
                if (msg == "")
                {
                    //put extra conditions here
                }
            }
            else if (radpage2.Checked == true)
            {
                strrutin = frmlastname.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void frmyemail_TextChanged(object sender, EventArgs e)
        {
            string msg = "";
            timer2.Enabled = false;
            //put firstname update box code here 
            if (radpage2.Checked == false)
            {
                stremail1 = frmyouremail.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(stremail1, txtyouremail.Text);
                if (msg == "")
                {
                    msg = CustomerMaintenance.Validator.IsValidEmail(stremail1, txtyouremail.Text);
                    //put extra conditions here
                }
                if (msg == "")
                {
                    if (stremail1.IndexOf("@tutanota.") == -1 && stremail1.IndexOf("@tuta.") == -1 && stremail1.IndexOf("@zoho.") == -1)
                    {
                        //aaa
                        msg = "We're sorry we are only allowing email addresses from Tutanota or Zoho currently, please use a compatible email address.";
                    }
                }

            }
            else if (radpage2.Checked == true)
            {
                strywater = frmyouremail.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void frmbilladdress_TextChanged(object sender, EventArgs e)
        {
            string msg = "";
            timer2.Enabled = false;

            if (radpage2.Checked == false)
            {
                strbilladdress = frmbilladdress.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(strbilladdress, txtbilladdress.Text);
                if (msg == "")
                {
                    //put extra conditions here
                }
            }
            else if (radpage2.Checked == true)
            {
                strrwater = frmbilladdress.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void frmccn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                //put firstname update box code here 
                timer2.Enabled = false;
                if (radpage2.Checked == false)
                {


                    strccn1 = frmccn.Text;
                    strccn1 = strccn1.Replace(" ", string.Empty);
                    //MessageBox.Show("confirmed page 2 work");
                    msg += CustomerMaintenance.Validator.IsPresent(strccn1, txtccn.Text);
                    if (msg == "")
                    {
                        //put extra conditions here
                    }
                    if (msg == "")
                    {
                        if (strccn1.Length != 16 || !CustomerMaintenance.Validator.IsDigitsOnly(strccn1))
                        {
                            //aaa
                            msg = "Please enter a valid credit card number";
                        }
                    }
                }

                else if (radpage2.Checked == true)
                {
                    strydayhour = frmccn.Text;
                }
                    if (msg != "")
                    {
                        txtinfobox.Text = msg;
                    }
                    else
                    {
                        timer2.Enabled = true;
                    }
                
            }
            catch { }
        }

        private void frmpin_TextChanged(object sender, EventArgs e)
        {
            string msg = "";
            //put firstname update box code here 
            timer2.Enabled = false;
            if (radpage2.Checked == false)
            {
                strpin = frmpin.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(strpin, txtpin.Text);
                if (msg == "")
                {
                    //put extra conditions here
                }
                if (msg == "")
                {
                    if (strpin.Length != 3 || !CustomerMaintenance.Validator.IsDigitsOnly(strpin))
                    {
                        //aaa
                        msg = "Please enter a valid Security code";
                    }
                }
            }
            else if (radpage2.Checked == true)
            {
                strrdayhour = frmpin.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
        }

        private void frmexpirdate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string msg = "";
                //put firstname update box code here 
                timer2.Enabled = false;
                if (radpage2.Checked == false)
                {
                    strexpirdate = frmexpirdate.Text;
                    strexpirdate = strexpirdate.Replace("/", string.Empty);
                    //MessageBox.Show("confirmed page 2 work");
                    msg += CustomerMaintenance.Validator.IsPresent(strexpirdate, txtexpirdate.Text);

                    if (msg == "")
                    {
                        if (strexpirdate.Length != 4)
                        {
                            //aaa
                            msg = "please enter a valid expiration date";
                        }
                        else if (Convert.ToInt32(strexpirdate.Remove(2)) > 12 || Convert.ToInt32(strexpirdate.Remove(0, 2)) < 23)
                        {
                            msg = "Please enter a valid expiration date.";
                        }
                    }
                }
                else if (radpage2.Checked == true)
                {
                    stryzodiac = frmexpirdate.Text;
                }
                if (msg != "")
                {
                    txtinfobox.Text = msg;
                }
                else
                {
                    timer2.Enabled = true;
                }
            }
            catch { }
        }

        private void frmremail_TextChanged(object sender, EventArgs e)
        {

            string msg = "";
            //put firstname update box code here 
            timer2.Enabled = false;
            if (radpage2.Checked == false)
            {
                stremail2 = frmrepemail.Text;
                //MessageBox.Show("confirmed page 2 work");
                msg += CustomerMaintenance.Validator.IsPresent(stremail2, txtrepemail.Text);
                if (msg == "")
                {
                    msg = CustomerMaintenance.Validator.IsValidEmail(stremail2, txtrepemail.Text);
                    //put extra conditions here
                }
                if (msg == "")
                {
                    if (stremail2.IndexOf("@tutanota.") == -1 && stremail2.IndexOf("@tuta.") == -1 && stremail2.IndexOf("@zoho.") == -1)
                    {
                        //aaa
                        msg = "We're sorry we are only allowing email addresses from Tutanota or Zoho currently, please use a compatible email address.";
                    }
                }
            }
            else if (radpage2.Checked == true)
            {
                strrzodiac = frmrepemail.Text;
            }
            if (msg != "")
            {
                txtinfobox.Text = msg;
            }
            else
            {
                timer2.Enabled = true;
            }
            grppage.Visible = true;
            txtaddopt.Visible = true;
            chkbestwishes.Visible = true;
            chkmessage.Visible = true;
            chkpicture.Visible = true;
            chkprayers.Visible = true;
            chkthoughts.Visible = true;
            chkworstwishes.Visible = true;
            timer1.Enabled = true;
            prgbar1.Visible = true;
            trackBar1.Visible = true;
            txtbar1.Visible = true;
            caldelidate1.Visible = true;
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().Location)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string fullpath = Path.Combine(exeDir, "..\\..\\..\\Resources\\imgnotdone.jpg");
            memebox.ImageLocation = fullpath;
            this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void caldelidate1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                daydelidatestart = caldelidate1.SelectionStart.Date;
                string msg = "";
                timer2.Enabled = false;
                if (msg == "")
                {
                    if (daydelidatestart < caldelidate1.TodayDate.Date)
                    {
                        //aaa
                        msg = "We have yet to discover how to travel faster than light or create a Flux Capacitor, as such we cannot travel back in time. Please select a day in the future.";
                    }
                }
                if (msg == "")
                {
                    if (daydelidatestart != caldelidate1.SelectionEnd.Date)
                    {
                        //aaa
                        msg = "Please select just one day to deliver the gift Card";
                    }
                }
                if (msg != "")
                {
                    txtinfobox.Text = msg;
                }
                else
                {
                    timer2.Enabled = true;
                }
                string exeFile = (new System.Uri(Assembly.GetEntryAssembly().Location)).AbsolutePath;
                string exeDir = Path.GetDirectoryName(exeFile);
                string fullpath = Path.Combine(exeDir, "..\\..\\..\\Resources\\imgsimple.jpg");
                memebox.ImageLocation = fullpath;
                this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
                string bounds = frmfirstname.Bounds.ToString();
            }
            catch { }
        }

        private void chkmessage_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkmessage.Checked)
            {
                using (var boxform4 = new Form4())
                {
                    var result = boxform4.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        strnicemessage = boxform4.rtnnicemessage;            //values preserved after close
                    }
                }
            }
        }

        private void chkthoughts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkthoughts.Checked)
            {
                boothoughts = true;
            }
            else { boothoughts = false; }

        }

        private void chkprayers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkprayers.Checked)
            {
                booprayers = true;
            }
            else { booprayers = false; }
        }

        private void chkbestwishes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbestwishes.Checked)
            {
                boobestwishes = true;
            }
            else
            {
                boobestwishes = false;
            }
        }

        private void chkworstwishes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkworstwishes.Checked)
            {
                booworstwishes = true;
            }
            else
            {
                booworstwishes = false;
            }
        }

        private void txtfirstname_Click(object sender, EventArgs e)
        {
            dumplingattack();
        }
        public void dumplingattack()
        {
            int intindex = 0;
            int intcap = 0;
            int intj = 0;
            int intid = 0;
            boodumpling = true;
            //rectanglestest = new PackingRectangle[lstcontrols1.Count];
            lstcontrols1.Shuffle();
            lstcontrols2.Clear();
            lstrectcontrols3.Clear();
            while (intindex < lstcontrols1.Count)
            {
            redo: intcap = rnd.Next(intindex, lstcontrols1.Count + 1);
                if (intcap == intindex)
                {
                    goto redo;
                }
                lstcontrols2.Add(new List<Control> { });
                for (int i = intindex; i < intcap; i++)
                {
                    //lstcontrols3.Add(lstcontrols1[i]);
                    lstcontrols2[intj].Add(lstcontrols1[i]);
                    //lstcontrols2[j][i] = lstcontrols1[i];
                };
                intindex = intcap;
                intj++;
            }
            //myList.Add(new List<string> { "a", "b" });
            //lstcontrols2.Add();
            for (int i = 0; i < lstcontrols2.Count; i++)
            {
                lstrectcontrols3.Add(new PackingRectangle[lstcontrols2[i].Count]);
                for (int j = 0; j < lstcontrols2[i].Count; j++)
                {
                    lstrectcontrols3[i][j].Id = intid;
                    lstrectcontrols3[i][j].X = ((uint)lstcontrols2[i][j].Location.X);
                    lstrectcontrols3[i][j].Y = ((uint)lstcontrols2[i][j].Location.Y);
                    lstrectcontrols3[i][j].Width = ((uint)lstcontrols2[i][j].Width);
                    lstrectcontrols3[i][j].Height = ((uint)lstcontrols2[i][j].Height);
                    intid++;
                }

            }
            PackingRectangle[] rectmasterbounds = new PackingRectangle[lstcontrols2.Count];
            for (int i = 0; i < lstrectcontrols3.Count; i++)
            {
                RectanglePacker.Pack(lstrectcontrols3[i], out PackingRectangle bounds, PackingHints.TryByPathologicalMultiplier);
                rectmasterbounds[i] = bounds;
                rectmasterbounds[i].Id = i;
            }
            RectanglePacker.Pack(rectmasterbounds, out PackingRectangle bounds1, PackingHints.TryByPathologicalMultiplier);
            for (int i = 0; i < lstrectcontrols3.Count; i++)
            {
                for (int j = 0; j < lstcontrols2[i].Count; j++)
                {
                    int k = 0;
                    while (rectmasterbounds[k].Id != i)
                    {
                        k++;
                    }
                    lstcontrols1[lstrectcontrols3[i][j].Id].Location = new Point(((int)rectmasterbounds[k].X) + ((int)lstrectcontrols3[i][j].X), ((int)rectmasterbounds[k].Y) + ((int)lstrectcontrols3[i][j].Y));
                    //lstcontrols1[j].Location = new Point(((int)rectanglestest[i].X), ((int)rectanglestest[i].Y));
                }

            }
            this.Size = new Size(((int)bounds1.Width + 50), ((int)bounds1.Height + 50));

            for (int i = 0; i < lstcontrols1.Count; i++)
            {
                lstcontrols1[i].TabIndex = rnd.Next(1, 100);
            }
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().Location)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string fullpath = Path.Combine(exeDir, "..\\..\\..\\Resources\\imgshuffle.png");
            memebox.ImageLocation = fullpath;
            this.BackgroundImage = Image.FromFile(fullpath);
            this.memebox.SizeMode = PictureBoxSizeMode.Zoom;
            for (int i = 0; i < lstcontrols1.Count(); i++)
            {
                try { lstcontrols1[i].BackColor = Color.Transparent; }
                catch (ArgumentException) { }
                /* in case you didnt figure it out, 
                 * the catch is skipping that element, 
                 * since it does this automatically 
                 * because it jumps to this line 
                 * i dont need any actual code here*/
            }
            //grpamount


            //return;
            // .Where(x => x is TextBox);
            //var colmatch = 
            var textboxes = this.Controls.OfType<Control>().Where(x => x is System.Windows.Forms.TextBox);
            List<Control> lstformboxes = new List<Control>();
            lstformboxes = textboxes.ToList();
            for (int i = 0; i < textboxes.Count(); i++)
            {
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            notblack: KnownColor randomcolorname = names[rnd.Next(names.Length)];
                if (randomcolorname == KnownColor.Black || randomcolorname == KnownColor.White || randomcolorname == KnownColor.Transparent || randomcolorname == KnownColor.ControlDarkDark || randomcolorname == KnownColor.ControlDark || randomcolorname == KnownColor.DarkViolet) { goto notblack; }
                Color colmatch = Color.FromKnownColor(randomcolorname);
                string strname = lstformboxes[i].Name;
                strname = strname.Remove(0, 3);
                strname = "txt" + strname;
                var formboxes = this.Controls.Find(strname, false);
                lstformboxes[i].BackColor = colmatch;
                formboxes[0].BackColor = colmatch;
            }
        }

        private void txtlastname_Click(object sender, EventArgs e)
        {

        }

    }
    static class MyExtensions
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
