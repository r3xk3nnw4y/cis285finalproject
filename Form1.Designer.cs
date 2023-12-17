using System.ComponentModel;

namespace cis285finalproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            frmfirstname = new System.Windows.Forms.TextBox();
            txtfirstname = new System.Windows.Forms.Label();
            txtpin = new System.Windows.Forms.Label();
            frmpin = new System.Windows.Forms.TextBox();
            txtccn = new System.Windows.Forms.Label();
            frmccn = new System.Windows.Forms.TextBox();
            txtbilladdress = new System.Windows.Forms.Label();
            frmbilladdress = new System.Windows.Forms.TextBox();
            txtyouremail = new System.Windows.Forms.Label();
            frmyouremail = new System.Windows.Forms.TextBox();
            txtlastname = new System.Windows.Forms.Label();
            frmlastname = new System.Windows.Forms.TextBox();
            txtexpirdate = new System.Windows.Forms.Label();
            frmexpirdate = new System.Windows.Forms.TextBox();
            grpcategory = new System.Windows.Forms.GroupBox();
            radcategory4 = new System.Windows.Forms.RadioButton();
            radcategory3 = new System.Windows.Forms.RadioButton();
            radcategory2 = new System.Windows.Forms.RadioButton();
            radcategory1 = new System.Windows.Forms.RadioButton();
            grpbrand = new System.Windows.Forms.GroupBox();
            radbrand3 = new System.Windows.Forms.RadioButton();
            radbrand2 = new System.Windows.Forms.RadioButton();
            radbrand1 = new System.Windows.Forms.RadioButton();
            grpamount = new System.Windows.Forms.GroupBox();
            frmamount4 = new System.Windows.Forms.TextBox();
            radamount4 = new System.Windows.Forms.RadioButton();
            radamount3 = new System.Windows.Forms.RadioButton();
            radamount2 = new System.Windows.Forms.RadioButton();
            radamount1 = new System.Windows.Forms.RadioButton();
            txtrepemail = new System.Windows.Forms.Label();
            frmrepemail = new System.Windows.Forms.TextBox();
            prgbar1 = new System.Windows.Forms.ProgressBar();
            caldelidate1 = new System.Windows.Forms.MonthCalendar();
            txtaddopt = new System.Windows.Forms.Label();
            btnsubmit = new System.Windows.Forms.Button();
            btnsave = new System.Windows.Forms.Button();
            btnclose = new System.Windows.Forms.Button();
            grppage = new System.Windows.Forms.GroupBox();
            radpage2 = new System.Windows.Forms.RadioButton();
            radpage1 = new System.Windows.Forms.RadioButton();
            chkmessage = new System.Windows.Forms.CheckBox();
            chkbestwishes = new System.Windows.Forms.CheckBox();
            chkprayers = new System.Windows.Forms.CheckBox();
            chkthoughts = new System.Windows.Forms.CheckBox();
            chkpicture = new System.Windows.Forms.CheckBox();
            chkworstwishes = new System.Windows.Forms.CheckBox();
            trackBar1 = new System.Windows.Forms.TrackBar();
            txtdelidate1 = new System.Windows.Forms.Label();
            filprettypicture = new System.Windows.Forms.OpenFileDialog();
            bwForm = new BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            txtinfobox = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            txtbar1 = new System.Windows.Forms.Label();
            memebox = new System.Windows.Forms.PictureBox();
            grpcategory.SuspendLayout();
            grpbrand.SuspendLayout();
            grpamount.SuspendLayout();
            grppage.SuspendLayout();
            ((ISupportInitialize)trackBar1).BeginInit();
            ((ISupportInitialize)memebox).BeginInit();
            SuspendLayout();
            // 
            // frmfirstname
            // 
            frmfirstname.Location = new System.Drawing.Point(169, 62);
            frmfirstname.Margin = new System.Windows.Forms.Padding(4);
            frmfirstname.Name = "frmfirstname";
            frmfirstname.Size = new System.Drawing.Size(247, 39);
            frmfirstname.TabIndex = 1;
            frmfirstname.TextChanged += frmfirstname_TextChanged;
            // 
            // txtfirstname
            // 
            txtfirstname.AutoSize = true;
            txtfirstname.Location = new System.Drawing.Point(3, 71);
            txtfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new System.Drawing.Size(129, 32);
            txtfirstname.TabIndex = 1;
            txtfirstname.Text = "First Name";
            txtfirstname.Click += txtfirstname_Click;
            // 
            // txtpin
            // 
            txtpin.AutoSize = true;
            txtpin.Location = new System.Drawing.Point(3, 301);
            txtpin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtpin.Name = "txtpin";
            txtpin.Size = new System.Drawing.Size(139, 32);
            txtpin.TabIndex = 3;
            txtpin.Text = "Security Pin";
            // 
            // frmpin
            // 
            frmpin.Location = new System.Drawing.Point(310, 301);
            frmpin.Margin = new System.Windows.Forms.Padding(4);
            frmpin.Name = "frmpin";
            frmpin.Size = new System.Drawing.Size(108, 39);
            frmpin.TabIndex = 6;
            frmpin.TextChanged += frmpin_TextChanged;
            // 
            // txtccn
            // 
            txtccn.AutoSize = true;
            txtccn.Location = new System.Drawing.Point(3, 258);
            txtccn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtccn.Name = "txtccn";
            txtccn.Size = new System.Drawing.Size(61, 32);
            txtccn.TabIndex = 5;
            txtccn.Text = "CCN";
            // 
            // frmccn
            // 
            frmccn.Location = new System.Drawing.Point(106, 252);
            frmccn.Margin = new System.Windows.Forms.Padding(4);
            frmccn.Name = "frmccn";
            frmccn.Size = new System.Drawing.Size(312, 39);
            frmccn.TabIndex = 5;
            frmccn.TextChanged += frmccn_TextChanged;
            // 
            // txtbilladdress
            // 
            txtbilladdress.AutoSize = true;
            txtbilladdress.Location = new System.Drawing.Point(3, 207);
            txtbilladdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtbilladdress.Name = "txtbilladdress";
            txtbilladdress.Size = new System.Drawing.Size(171, 32);
            txtbilladdress.TabIndex = 7;
            txtbilladdress.Text = "Billing Address";
            // 
            // frmbilladdress
            // 
            frmbilladdress.Location = new System.Drawing.Point(212, 205);
            frmbilladdress.Margin = new System.Windows.Forms.Padding(4);
            frmbilladdress.Name = "frmbilladdress";
            frmbilladdress.Size = new System.Drawing.Size(205, 39);
            frmbilladdress.TabIndex = 4;
            frmbilladdress.TextChanged += frmbilladdress_TextChanged;
            // 
            // txtyouremail
            // 
            txtyouremail.AutoSize = true;
            txtyouremail.Location = new System.Drawing.Point(3, 160);
            txtyouremail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtyouremail.Name = "txtyouremail";
            txtyouremail.Size = new System.Drawing.Size(125, 32);
            txtyouremail.TabIndex = 9;
            txtyouremail.Text = "Your Email";
            // 
            // frmyouremail
            // 
            frmyouremail.Location = new System.Drawing.Point(169, 158);
            frmyouremail.Margin = new System.Windows.Forms.Padding(4);
            frmyouremail.Name = "frmyouremail";
            frmyouremail.Size = new System.Drawing.Size(249, 39);
            frmyouremail.TabIndex = 3;
            frmyouremail.TextChanged += frmyemail_TextChanged;
            // 
            // txtlastname
            // 
            txtlastname.AutoSize = true;
            txtlastname.Location = new System.Drawing.Point(3, 115);
            txtlastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new System.Drawing.Size(126, 32);
            txtlastname.TabIndex = 11;
            txtlastname.Text = "Last Name";
            txtlastname.Click += txtlastname_Click;
            // 
            // frmlastname
            // 
            frmlastname.Location = new System.Drawing.Point(169, 111);
            frmlastname.Margin = new System.Windows.Forms.Padding(4);
            frmlastname.Name = "frmlastname";
            frmlastname.Size = new System.Drawing.Size(249, 39);
            frmlastname.TabIndex = 2;
            frmlastname.TextChanged += frmlastname_TextChanged;
            // 
            // txtexpirdate
            // 
            txtexpirdate.AutoSize = true;
            txtexpirdate.Location = new System.Drawing.Point(3, 348);
            txtexpirdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtexpirdate.Name = "txtexpirdate";
            txtexpirdate.Size = new System.Drawing.Size(176, 32);
            txtexpirdate.TabIndex = 13;
            txtexpirdate.Text = "Expiration Date";
            // 
            // frmexpirdate
            // 
            frmexpirdate.Location = new System.Drawing.Point(310, 348);
            frmexpirdate.Margin = new System.Windows.Forms.Padding(4);
            frmexpirdate.Name = "frmexpirdate";
            frmexpirdate.Size = new System.Drawing.Size(108, 39);
            frmexpirdate.TabIndex = 7;
            frmexpirdate.TextChanged += frmexpirdate_TextChanged;
            // 
            // grpcategory
            // 
            grpcategory.Controls.Add(radcategory4);
            grpcategory.Controls.Add(radcategory3);
            grpcategory.Controls.Add(radcategory2);
            grpcategory.Controls.Add(radcategory1);
            grpcategory.Location = new System.Drawing.Point(940, 49);
            grpcategory.Margin = new System.Windows.Forms.Padding(4);
            grpcategory.Name = "grpcategory";
            grpcategory.Padding = new System.Windows.Forms.Padding(4);
            grpcategory.Size = new System.Drawing.Size(316, 224);
            grpcategory.TabIndex = 14;
            grpcategory.TabStop = false;
            grpcategory.Text = "Category";
            // 
            // radcategory4
            // 
            radcategory4.AutoSize = true;
            radcategory4.Location = new System.Drawing.Point(30, 173);
            radcategory4.Margin = new System.Windows.Forms.Padding(4);
            radcategory4.Name = "radcategory4";
            radcategory4.Size = new System.Drawing.Size(106, 36);
            radcategory4.TabIndex = 12;
            radcategory4.Text = "Other";
            radcategory4.UseVisualStyleBackColor = true;
            radcategory4.CheckedChanged += radcategory4_CheckedChanged;
            // 
            // radcategory3
            // 
            radcategory3.AutoSize = true;
            radcategory3.Location = new System.Drawing.Point(30, 128);
            radcategory3.Margin = new System.Windows.Forms.Padding(4);
            radcategory3.Name = "radcategory3";
            radcategory3.Size = new System.Drawing.Size(116, 36);
            radcategory3.TabIndex = 11;
            radcategory3.Text = "Dining";
            radcategory3.UseVisualStyleBackColor = true;
            radcategory3.CheckedChanged += radcategory3_CheckedChanged;
            // 
            // radcategory2
            // 
            radcategory2.AutoSize = true;
            radcategory2.Location = new System.Drawing.Point(30, 83);
            radcategory2.Margin = new System.Windows.Forms.Padding(4);
            radcategory2.Name = "radcategory2";
            radcategory2.Size = new System.Drawing.Size(136, 36);
            radcategory2.TabIndex = 10;
            radcategory2.Text = "Clothing";
            radcategory2.UseVisualStyleBackColor = true;
            radcategory2.CheckedChanged += radcategory2_CheckedChanged;
            // 
            // radcategory1
            // 
            radcategory1.AutoSize = true;
            radcategory1.Checked = true;
            radcategory1.Location = new System.Drawing.Point(30, 41);
            radcategory1.Margin = new System.Windows.Forms.Padding(4);
            radcategory1.Name = "radcategory1";
            radcategory1.Size = new System.Drawing.Size(103, 36);
            radcategory1.TabIndex = 9;
            radcategory1.TabStop = true;
            radcategory1.Text = "Retail";
            radcategory1.UseVisualStyleBackColor = true;
            radcategory1.CheckedChanged += radcategory1_CheckedChanged;
            // 
            // grpbrand
            // 
            grpbrand.Controls.Add(radbrand3);
            grpbrand.Controls.Add(radbrand2);
            grpbrand.Controls.Add(radbrand1);
            grpbrand.Location = new System.Drawing.Point(940, 279);
            grpbrand.Margin = new System.Windows.Forms.Padding(4);
            grpbrand.Name = "grpbrand";
            grpbrand.Padding = new System.Windows.Forms.Padding(4);
            grpbrand.Size = new System.Drawing.Size(316, 220);
            grpbrand.TabIndex = 15;
            grpbrand.TabStop = false;
            grpbrand.Text = "Brand";
            // 
            // radbrand3
            // 
            radbrand3.AutoSize = true;
            radbrand3.Location = new System.Drawing.Point(30, 139);
            radbrand3.Margin = new System.Windows.Forms.Padding(4);
            radbrand3.Name = "radbrand3";
            radbrand3.Size = new System.Drawing.Size(109, 36);
            radbrand3.TabIndex = 15;
            radbrand3.Text = "Publix";
            radbrand3.UseVisualStyleBackColor = true;
            radbrand3.CheckedChanged += radbrand3_CheckedChanged;
            // 
            // radbrand2
            // 
            radbrand2.AutoSize = true;
            radbrand2.Location = new System.Drawing.Point(30, 94);
            radbrand2.Margin = new System.Windows.Forms.Padding(4);
            radbrand2.Name = "radbrand2";
            radbrand2.Size = new System.Drawing.Size(110, 36);
            radbrand2.TabIndex = 14;
            radbrand2.Text = "Target";
            radbrand2.UseVisualStyleBackColor = true;
            radbrand2.CheckedChanged += radbrand2_CheckedChanged;
            // 
            // radbrand1
            // 
            radbrand1.AutoSize = true;
            radbrand1.Checked = true;
            radbrand1.Location = new System.Drawing.Point(30, 51);
            radbrand1.Margin = new System.Windows.Forms.Padding(4);
            radbrand1.Name = "radbrand1";
            radbrand1.Size = new System.Drawing.Size(133, 36);
            radbrand1.TabIndex = 13;
            radbrand1.TabStop = true;
            radbrand1.Text = "Walmart";
            radbrand1.UseVisualStyleBackColor = true;
            radbrand1.CheckedChanged += radbrand1_CheckedChanged;
            // 
            // grpamount
            // 
            grpamount.Controls.Add(frmamount4);
            grpamount.Controls.Add(radamount4);
            grpamount.Controls.Add(radamount3);
            grpamount.Controls.Add(radamount2);
            grpamount.Controls.Add(radamount1);
            grpamount.Location = new System.Drawing.Point(940, 508);
            grpamount.Margin = new System.Windows.Forms.Padding(4);
            grpamount.Name = "grpamount";
            grpamount.Padding = new System.Windows.Forms.Padding(4);
            grpamount.Size = new System.Drawing.Size(316, 228);
            grpamount.TabIndex = 16;
            grpamount.TabStop = false;
            grpamount.Text = "Amount";
            grpamount.Enter += grpamount_Enter;
            // 
            // frmamount4
            // 
            frmamount4.Location = new System.Drawing.Point(156, 181);
            frmamount4.Margin = new System.Windows.Forms.Padding(4);
            frmamount4.Name = "frmamount4";
            frmamount4.Size = new System.Drawing.Size(108, 39);
            frmamount4.TabIndex = 20;
            // 
            // radamount4
            // 
            radamount4.AutoSize = true;
            radamount4.Location = new System.Drawing.Point(30, 181);
            radamount4.Margin = new System.Windows.Forms.Padding(4);
            radamount4.Name = "radamount4";
            radamount4.Size = new System.Drawing.Size(123, 36);
            radamount4.TabIndex = 19;
            radamount4.TabStop = true;
            radamount4.Text = "custom";
            radamount4.UseVisualStyleBackColor = true;
            // 
            // radamount3
            // 
            radamount3.AutoSize = true;
            radamount3.Location = new System.Drawing.Point(30, 139);
            radamount3.Margin = new System.Windows.Forms.Padding(4);
            radamount3.Name = "radamount3";
            radamount3.Size = new System.Drawing.Size(97, 36);
            radamount3.TabIndex = 18;
            radamount3.Text = "$100";
            radamount3.UseVisualStyleBackColor = true;
            // 
            // radamount2
            // 
            radamount2.AutoSize = true;
            radamount2.Location = new System.Drawing.Point(30, 94);
            radamount2.Margin = new System.Windows.Forms.Padding(4);
            radamount2.Name = "radamount2";
            radamount2.Size = new System.Drawing.Size(84, 36);
            radamount2.TabIndex = 17;
            radamount2.Text = "$50";
            radamount2.UseVisualStyleBackColor = true;
            // 
            // radamount1
            // 
            radamount1.AutoSize = true;
            radamount1.Location = new System.Drawing.Point(30, 51);
            radamount1.Margin = new System.Windows.Forms.Padding(4);
            radamount1.Name = "radamount1";
            radamount1.Size = new System.Drawing.Size(84, 36);
            radamount1.TabIndex = 16;
            radamount1.Text = "$10";
            radamount1.UseVisualStyleBackColor = true;
            // 
            // txtrepemail
            // 
            txtrepemail.AutoSize = true;
            txtrepemail.Location = new System.Drawing.Point(3, 399);
            txtrepemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtrepemail.Name = "txtrepemail";
            txtrepemail.Size = new System.Drawing.Size(201, 32);
            txtrepemail.TabIndex = 18;
            txtrepemail.Text = "Recieptants email";
            // 
            // frmrepemail
            // 
            frmrepemail.Location = new System.Drawing.Point(234, 395);
            frmrepemail.Margin = new System.Windows.Forms.Padding(4);
            frmrepemail.Name = "frmrepemail";
            frmrepemail.Size = new System.Drawing.Size(184, 39);
            frmrepemail.TabIndex = 8;
            frmrepemail.TextChanged += frmremail_TextChanged;
            // 
            // prgbar1
            // 
            prgbar1.AccessibleDescription = "meep";
            prgbar1.Location = new System.Drawing.Point(880, 777);
            prgbar1.Margin = new System.Windows.Forms.Padding(4);
            prgbar1.Maximum = 10000;
            prgbar1.Name = "prgbar1";
            prgbar1.Size = new System.Drawing.Size(377, 30);
            prgbar1.Step = 1;
            prgbar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            prgbar1.TabIndex = 19;
            prgbar1.Tag = "hello world";
            prgbar1.Visible = false;
            // 
            // caldelidate1
            // 
            caldelidate1.Cursor = System.Windows.Forms.Cursors.Cross;
            caldelidate1.Font = new System.Drawing.Font("Segoe Script", 7.875F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            caldelidate1.Location = new System.Drawing.Point(431, 73);
            caldelidate1.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            caldelidate1.Name = "caldelidate1";
            caldelidate1.ShowToday = false;
            caldelidate1.TabIndex = 20;
            caldelidate1.Visible = false;
            caldelidate1.DateChanged += caldelidate1_DateChanged;
            // 
            // txtaddopt
            // 
            txtaddopt.AutoSize = true;
            txtaddopt.Location = new System.Drawing.Point(30, 555);
            txtaddopt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtaddopt.Name = "txtaddopt";
            txtaddopt.Size = new System.Drawing.Size(207, 32);
            txtaddopt.TabIndex = 22;
            txtaddopt.Text = "additional options";
            txtaddopt.Visible = false;
            txtaddopt.Click += label2_Click;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new System.Drawing.Point(565, 759);
            btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new System.Drawing.Size(126, 51);
            btnsubmit.TabIndex = 23;
            btnsubmit.Text = "submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new System.Drawing.Point(433, 759);
            btnsave.Margin = new System.Windows.Forms.Padding(4);
            btnsave.Name = "btnsave";
            btnsave.Size = new System.Drawing.Size(126, 51);
            btnsave.TabIndex = 24;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new System.Drawing.Point(698, 759);
            btnclose.Margin = new System.Windows.Forms.Padding(4);
            btnclose.Name = "btnclose";
            btnclose.Size = new System.Drawing.Size(126, 51);
            btnclose.TabIndex = 25;
            btnclose.Text = "close";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // grppage
            // 
            grppage.Controls.Add(radpage2);
            grppage.Controls.Add(radpage1);
            grppage.Location = new System.Drawing.Point(30, 446);
            grppage.Margin = new System.Windows.Forms.Padding(4);
            grppage.Name = "grppage";
            grppage.Padding = new System.Windows.Forms.Padding(4);
            grppage.Size = new System.Drawing.Size(282, 105);
            grppage.TabIndex = 26;
            grppage.TabStop = false;
            grppage.Text = "PAGE selector";
            grppage.Visible = false;
            // 
            // radpage2
            // 
            radpage2.AutoSize = true;
            radpage2.Location = new System.Drawing.Point(139, 34);
            radpage2.Margin = new System.Windows.Forms.Padding(4);
            radpage2.Name = "radpage2";
            radpage2.Size = new System.Drawing.Size(116, 36);
            radpage2.TabIndex = 2;
            radpage2.TabStop = true;
            radpage2.Text = "Page 2";
            radpage2.UseVisualStyleBackColor = true;
            radpage2.CheckedChanged += radioButton11_CheckedChanged;
            // 
            // radpage1
            // 
            radpage1.AutoSize = true;
            radpage1.Location = new System.Drawing.Point(13, 34);
            radpage1.Margin = new System.Windows.Forms.Padding(4);
            radpage1.Name = "radpage1";
            radpage1.Size = new System.Drawing.Size(116, 36);
            radpage1.TabIndex = 1;
            radpage1.TabStop = true;
            radpage1.Text = "Page 1";
            radpage1.UseVisualStyleBackColor = true;
            radpage1.CheckedChanged += radpage1_CheckedChanged;
            // 
            // chkmessage
            // 
            chkmessage.AutoSize = true;
            chkmessage.Location = new System.Drawing.Point(37, 593);
            chkmessage.Margin = new System.Windows.Forms.Padding(4);
            chkmessage.Name = "chkmessage";
            chkmessage.Size = new System.Drawing.Size(190, 36);
            chkmessage.TabIndex = 28;
            chkmessage.Text = "nice message";
            chkmessage.UseVisualStyleBackColor = true;
            chkmessage.Visible = false;
            chkmessage.CheckedChanged += chkmessage_CheckedChanged;
            // 
            // chkbestwishes
            // 
            chkbestwishes.AutoSize = true;
            chkbestwishes.Location = new System.Drawing.Point(37, 683);
            chkbestwishes.Margin = new System.Windows.Forms.Padding(4);
            chkbestwishes.Name = "chkbestwishes";
            chkbestwishes.Size = new System.Drawing.Size(168, 36);
            chkbestwishes.TabIndex = 29;
            chkbestwishes.Text = "best wishes";
            chkbestwishes.UseVisualStyleBackColor = true;
            chkbestwishes.Visible = false;
            chkbestwishes.CheckedChanged += chkbestwishes_CheckedChanged;
            // 
            // chkprayers
            // 
            chkprayers.AutoSize = true;
            chkprayers.Location = new System.Drawing.Point(243, 638);
            chkprayers.Margin = new System.Windows.Forms.Padding(4);
            chkprayers.Name = "chkprayers";
            chkprayers.Size = new System.Drawing.Size(123, 36);
            chkprayers.TabIndex = 30;
            chkprayers.Text = "prayers";
            chkprayers.UseVisualStyleBackColor = true;
            chkprayers.Visible = false;
            chkprayers.CheckedChanged += chkprayers_CheckedChanged;
            // 
            // chkthoughts
            // 
            chkthoughts.AutoSize = true;
            chkthoughts.Location = new System.Drawing.Point(37, 638);
            chkthoughts.Margin = new System.Windows.Forms.Padding(4);
            chkthoughts.Name = "chkthoughts";
            chkthoughts.Size = new System.Drawing.Size(142, 36);
            chkthoughts.TabIndex = 31;
            chkthoughts.Text = "thoughts";
            chkthoughts.UseVisualStyleBackColor = true;
            chkthoughts.Visible = false;
            chkthoughts.CheckedChanged += chkthoughts_CheckedChanged;
            // 
            // chkpicture
            // 
            chkpicture.AutoSize = true;
            chkpicture.Location = new System.Drawing.Point(243, 593);
            chkpicture.Margin = new System.Windows.Forms.Padding(4);
            chkpicture.Name = "chkpicture";
            chkpicture.Size = new System.Drawing.Size(190, 36);
            chkpicture.TabIndex = 32;
            chkpicture.Text = "pretty picture";
            chkpicture.UseVisualStyleBackColor = true;
            chkpicture.Visible = false;
            chkpicture.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // chkworstwishes
            // 
            chkworstwishes.AutoSize = true;
            chkworstwishes.Location = new System.Drawing.Point(243, 683);
            chkworstwishes.Margin = new System.Windows.Forms.Padding(4);
            chkworstwishes.Name = "chkworstwishes";
            chkworstwishes.Size = new System.Drawing.Size(180, 36);
            chkworstwishes.TabIndex = 33;
            chkworstwishes.Text = "worst wishes";
            chkworstwishes.UseVisualStyleBackColor = true;
            chkworstwishes.Visible = false;
            chkworstwishes.CheckedChanged += chkworstwishes_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(30, 747);
            trackBar1.Margin = new System.Windows.Forms.Padding(4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(368, 93);
            trackBar1.TabIndex = 34;
            trackBar1.Visible = false;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // txtdelidate1
            // 
            txtdelidate1.AutoSize = true;
            txtdelidate1.Location = new System.Drawing.Point(559, 49);
            txtdelidate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            txtdelidate1.Name = "txtdelidate1";
            txtdelidate1.Size = new System.Drawing.Size(163, 32);
            txtdelidate1.TabIndex = 35;
            txtdelidate1.Text = "Delivery Date:";
            txtdelidate1.Visible = false;
            // 
            // filprettypicture
            // 
            filprettypicture.FileName = "openFileDialog1";
            // 
            // bwForm
            // 
            bwForm.WorkerReportsProgress = true;
            bwForm.DoWork += backgroundWorker1_DoWork;
            bwForm.ProgressChanged += BwForm_ProgressChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // txtinfobox
            // 
            txtinfobox.AutoSize = true;
            txtinfobox.Location = new System.Drawing.Point(17, 875);
            txtinfobox.Margin = new System.Windows.Forms.Padding(0);
            txtinfobox.MaximumSize = new System.Drawing.Size(1300, 64);
            txtinfobox.MinimumSize = new System.Drawing.Size(1263, 32);
            txtinfobox.Name = "txtinfobox";
            txtinfobox.Size = new System.Drawing.Size(1263, 32);
            txtinfobox.TabIndex = 36;
            txtinfobox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // txtbar1
            // 
            txtbar1.AutoSize = true;
            txtbar1.Location = new System.Drawing.Point(934, 811);
            txtbar1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            txtbar1.Name = "txtbar1";
            txtbar1.Size = new System.Drawing.Size(307, 64);
            txtbar1.TabIndex = 37;
            txtbar1.Text = "don't let this fill up, \r\nuse the track bar to lower it";
            txtbar1.Visible = false;
            // 
            // memebox
            // 
            memebox.Location = new System.Drawing.Point(433, 508);
            memebox.Margin = new System.Windows.Forms.Padding(4);
            memebox.Name = "memebox";
            memebox.Size = new System.Drawing.Size(435, 228);
            memebox.TabIndex = 38;
            memebox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1276, 962);
            Controls.Add(memebox);
            Controls.Add(txtbar1);
            Controls.Add(txtinfobox);
            Controls.Add(txtdelidate1);
            Controls.Add(trackBar1);
            Controls.Add(chkworstwishes);
            Controls.Add(chkpicture);
            Controls.Add(chkthoughts);
            Controls.Add(chkprayers);
            Controls.Add(chkbestwishes);
            Controls.Add(chkmessage);
            Controls.Add(grppage);
            Controls.Add(btnclose);
            Controls.Add(btnsave);
            Controls.Add(btnsubmit);
            Controls.Add(txtaddopt);
            Controls.Add(caldelidate1);
            Controls.Add(prgbar1);
            Controls.Add(txtrepemail);
            Controls.Add(frmrepemail);
            Controls.Add(grpamount);
            Controls.Add(grpbrand);
            Controls.Add(grpcategory);
            Controls.Add(txtexpirdate);
            Controls.Add(frmexpirdate);
            Controls.Add(txtlastname);
            Controls.Add(frmlastname);
            Controls.Add(txtyouremail);
            Controls.Add(frmyouremail);
            Controls.Add(txtbilladdress);
            Controls.Add(frmbilladdress);
            Controls.Add(txtccn);
            Controls.Add(frmccn);
            Controls.Add(txtpin);
            Controls.Add(frmpin);
            Controls.Add(txtfirstname);
            Controls.Add(frmfirstname);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(1116, 664);
            Name = "Form1";
            Text = "Gift Card distributors LLC";
            grpcategory.ResumeLayout(false);
            grpcategory.PerformLayout();
            grpbrand.ResumeLayout(false);
            grpbrand.PerformLayout();
            grpamount.ResumeLayout(false);
            grpamount.PerformLayout();
            grppage.ResumeLayout(false);
            grppage.PerformLayout();
            ((ISupportInitialize)trackBar1).EndInit();
            ((ISupportInitialize)memebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox frmfirstname;
        private System.Windows.Forms.Label txtfirstname;
        private System.Windows.Forms.Label txtpin;
        private System.Windows.Forms.TextBox frmpin;
        private System.Windows.Forms.Label txtccn;
        private System.Windows.Forms.TextBox frmccn;
        private System.Windows.Forms.Label txtbilladdress;
        private System.Windows.Forms.TextBox frmbilladdress;
        private System.Windows.Forms.Label txtyouremail;
        private System.Windows.Forms.TextBox frmyouremail;
        private System.Windows.Forms.Label txtlastname;
        private System.Windows.Forms.TextBox frmlastname;
        private System.Windows.Forms.Label txtexpirdate;
        private System.Windows.Forms.TextBox frmexpirdate;
        private System.Windows.Forms.GroupBox grpcategory;
        private System.Windows.Forms.GroupBox grpbrand;
        private System.Windows.Forms.GroupBox grpamount;
        private System.Windows.Forms.RadioButton radcategory3;
        private System.Windows.Forms.RadioButton radcategory2;
        private System.Windows.Forms.RadioButton radcategory1;
        private System.Windows.Forms.RadioButton radbrand3;
        private System.Windows.Forms.RadioButton radbrand2;
        private System.Windows.Forms.RadioButton radbrand1;
        private System.Windows.Forms.RadioButton radamount3;
        private System.Windows.Forms.RadioButton radamount2;
        private System.Windows.Forms.RadioButton radamount1;
        private System.Windows.Forms.Label txtrepemail;
        private System.Windows.Forms.TextBox frmrepemail;
        private System.Windows.Forms.ProgressBar prgbar1;
        private System.Windows.Forms.MonthCalendar caldelidate1;
        private System.Windows.Forms.Label txtaddopt;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox grppage;
        private System.Windows.Forms.RadioButton radpage2;
        private System.Windows.Forms.RadioButton radpage1;
        private System.Windows.Forms.CheckBox chkmessage;
        private System.Windows.Forms.CheckBox chkbestwishes;
        private System.Windows.Forms.CheckBox chkprayers;
        private System.Windows.Forms.CheckBox chkthoughts;
        private System.Windows.Forms.CheckBox chkpicture;
        private System.Windows.Forms.CheckBox chkworstwishes;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radcategory4;
        private System.Windows.Forms.Label txtdelidate1;
        private System.Windows.Forms.RadioButton radamount4;
        private System.Windows.Forms.TextBox frmamount4;
        private System.Windows.Forms.OpenFileDialog filprettypicture;
        private BackgroundWorker bwForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtinfobox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label txtbar1;
        private System.Windows.Forms.PictureBox memebox;
    }
}

