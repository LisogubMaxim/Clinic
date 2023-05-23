namespace OOP
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editDoctor = new System.Windows.Forms.Button();
            this.deleteDoctor = new System.Windows.Forms.Button();
            this.doctorSpeciality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorMiddleName = new System.Windows.Forms.TextBox();
            this.doctorLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.doctorName = new System.Windows.Forms.TextBox();
            this.doctorId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.listDoctor = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.patientAbout = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.patientMiddleName = new System.Windows.Forms.TextBox();
            this.patientLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.patientId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.listPatient = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 414);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.listDoctor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(460, 385);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Лікарі";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editDoctor);
            this.panel3.Controls.Add(this.deleteDoctor);
            this.panel3.Controls.Add(this.doctorSpeciality);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.doctorMiddleName);
            this.panel3.Controls.Add(this.doctorLastName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.doctorName);
            this.panel3.Controls.Add(this.doctorId);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(138, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 373);
            this.panel3.TabIndex = 9;
            // 
            // editDoctor
            // 
            this.editDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.editDoctor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editDoctor.FlatAppearance.BorderSize = 0;
            this.editDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.editDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDoctor.Image = global::OOP.Properties.Resources.Iconsmind_Outline_Pen_3_16;
            this.editDoctor.Location = new System.Drawing.Point(251, 3);
            this.editDoctor.Name = "editDoctor";
            this.editDoctor.Size = new System.Drawing.Size(27, 25);
            this.editDoctor.TabIndex = 36;
            this.editDoctor.UseVisualStyleBackColor = false;
            this.editDoctor.Click += new System.EventHandler(this.editDoctor_Click);
            // 
            // deleteDoctor
            // 
            this.deleteDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.deleteDoctor.FlatAppearance.BorderSize = 0;
            this.deleteDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deleteDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDoctor.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Trash_can_outline_16;
            this.deleteDoctor.Location = new System.Drawing.Point(284, 3);
            this.deleteDoctor.Name = "deleteDoctor";
            this.deleteDoctor.Size = new System.Drawing.Size(27, 25);
            this.deleteDoctor.TabIndex = 35;
            this.deleteDoctor.UseVisualStyleBackColor = false;
            this.deleteDoctor.Click += new System.EventHandler(this.deleteDoctor_Click);
            // 
            // doctorSpeciality
            // 
            this.doctorSpeciality.BackColor = System.Drawing.Color.White;
            this.doctorSpeciality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorSpeciality.Enabled = false;
            this.doctorSpeciality.Location = new System.Drawing.Point(138, 175);
            this.doctorSpeciality.Name = "doctorSpeciality";
            this.doctorSpeciality.Size = new System.Drawing.Size(151, 24);
            this.doctorSpeciality.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Спеціальність:";
            // 
            // doctorMiddleName
            // 
            this.doctorMiddleName.BackColor = System.Drawing.Color.White;
            this.doctorMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorMiddleName.Enabled = false;
            this.doctorMiddleName.Location = new System.Drawing.Point(138, 145);
            this.doctorMiddleName.Name = "doctorMiddleName";
            this.doctorMiddleName.Size = new System.Drawing.Size(151, 24);
            this.doctorMiddleName.TabIndex = 30;
            // 
            // doctorLastName
            // 
            this.doctorLastName.BackColor = System.Drawing.Color.White;
            this.doctorLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorLastName.Enabled = false;
            this.doctorLastName.Location = new System.Drawing.Point(138, 115);
            this.doctorLastName.Name = "doctorLastName";
            this.doctorLastName.Size = new System.Drawing.Size(151, 24);
            this.doctorLastName.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Прізвище:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "По-батькові:";
            // 
            // doctorName
            // 
            this.doctorName.BackColor = System.Drawing.Color.White;
            this.doctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorName.Enabled = false;
            this.doctorName.Location = new System.Drawing.Point(138, 85);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(151, 24);
            this.doctorName.TabIndex = 26;
            // 
            // doctorId
            // 
            this.doctorId.BackColor = System.Drawing.Color.White;
            this.doctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorId.Enabled = false;
            this.doctorId.Location = new System.Drawing.Point(138, 55);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(151, 24);
            this.doctorId.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ім\'я:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "id:";
            // 
            // listDoctor
            // 
            this.listDoctor.BackColor = System.Drawing.Color.White;
            this.listDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDoctor.FormattingEnabled = true;
            this.listDoctor.ItemHeight = 16;
            this.listDoctor.Location = new System.Drawing.Point(7, 6);
            this.listDoctor.Name = "listDoctor";
            this.listDoctor.Size = new System.Drawing.Size(125, 370);
            this.listDoctor.TabIndex = 8;
            this.listDoctor.SelectedIndexChanged += new System.EventHandler(this.listDoctor_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.listPatient);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пацієнти";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.patientAbout);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.patientMiddleName);
            this.panel1.Controls.Add(this.patientLastName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.patientName);
            this.panel1.Controls.Add(this.patientId);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(138, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 373);
            this.panel1.TabIndex = 11;
            // 
            // patientAbout
            // 
            this.patientAbout.BackColor = System.Drawing.Color.White;
            this.patientAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.patientAbout.Location = new System.Drawing.Point(34, 187);
            this.patientAbout.Multiline = true;
            this.patientAbout.Name = "patientAbout";
            this.patientAbout.ReadOnly = true;
            this.patientAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.patientAbout.Size = new System.Drawing.Size(255, 183);
            this.patientAbout.TabIndex = 37;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Trash_can_outline_16;
            this.button3.Location = new System.Drawing.Point(284, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 25);
            this.button3.TabIndex = 35;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // patientMiddleName
            // 
            this.patientMiddleName.BackColor = System.Drawing.Color.White;
            this.patientMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientMiddleName.Enabled = false;
            this.patientMiddleName.Location = new System.Drawing.Point(138, 145);
            this.patientMiddleName.Name = "patientMiddleName";
            this.patientMiddleName.Size = new System.Drawing.Size(151, 24);
            this.patientMiddleName.TabIndex = 30;
            // 
            // patientLastName
            // 
            this.patientLastName.BackColor = System.Drawing.Color.White;
            this.patientLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientLastName.Enabled = false;
            this.patientLastName.Location = new System.Drawing.Point(138, 115);
            this.patientLastName.Name = "patientLastName";
            this.patientLastName.Size = new System.Drawing.Size(151, 24);
            this.patientLastName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Прізвище:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "По-батькові:";
            // 
            // patientName
            // 
            this.patientName.BackColor = System.Drawing.Color.White;
            this.patientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientName.Enabled = false;
            this.patientName.Location = new System.Drawing.Point(138, 85);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(151, 24);
            this.patientName.TabIndex = 26;
            // 
            // patientId
            // 
            this.patientId.BackColor = System.Drawing.Color.White;
            this.patientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patientId.Enabled = false;
            this.patientId.Location = new System.Drawing.Point(138, 55);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(151, 24);
            this.patientId.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Ім\'я:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "id:";
            // 
            // listPatient
            // 
            this.listPatient.BackColor = System.Drawing.Color.White;
            this.listPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPatient.FormattingEnabled = true;
            this.listPatient.ItemHeight = 16;
            this.listPatient.Location = new System.Drawing.Point(7, 6);
            this.listPatient.Name = "listPatient";
            this.listPatient.Size = new System.Drawing.Size(125, 370);
            this.listPatient.TabIndex = 10;
            this.listPatient.SelectedIndexChanged += new System.EventHandler(this.listPatient_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxRepeatPassword);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBoxPassword);
            this.tabPage3.Controls.Add(this.textBoxLogin);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(460, 385);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Додати";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Анестезіолог",
            "Гастроентеролог",
            "Гематолог",
            "Генетик",
            "Ендокринолог",
            "Імунолог",
            "Інфекціоніст",
            "Кардіолог",
            "Нарколог",
            "Невропатолог",
            "Нейрохірург",
            "Онколог",
            "Ортопед",
            "Офтальмолог",
            "Педіатр",
            "Психіатр",
            "Психолог",
            "Терапевт",
            "Хірург"});
            this.comboBox1.Location = new System.Drawing.Point(227, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 71;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 21);
            this.checkBox1.TabIndex = 70;
            this.checkBox1.Text = "Показати пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Repeat password";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepeatPassword.BackColor = System.Drawing.Color.White;
            this.textBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(227, 231);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(166, 24);
            this.textBoxRepeatPassword.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Login";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(137, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 65;
            this.button1.Text = "Зареєструватися";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Location = new System.Drawing.Point(227, 201);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(166, 24);
            this.textBoxPassword.TabIndex = 64;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackColor = System.Drawing.Color.White;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Location = new System.Drawing.Point(227, 171);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(166, 24);
            this.textBoxLogin.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Спеціальність:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(227, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 24);
            this.textBox3.TabIndex = 60;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(227, 81);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(166, 24);
            this.textBox6.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Прізвище:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "По-батькові:";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(227, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 24);
            this.textBox7.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 55;
            this.label15.Text = "Ім\'я:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(507, 483);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox doctorSpeciality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox doctorMiddleName;
        private System.Windows.Forms.TextBox doctorLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox doctorName;
        private System.Windows.Forms.TextBox doctorId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listDoctor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button editDoctor;
        private System.Windows.Forms.Button deleteDoctor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox patientAbout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox patientMiddleName;
        private System.Windows.Forms.TextBox patientLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listPatient;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}