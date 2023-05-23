namespace OOP
{
    partial class DoctorForm
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
            this.listMeet = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.deleteMeet = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.editDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listAllPatient = new System.Windows.Forms.ListBox();
            this.addPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createNewMeet = new System.Windows.Forms.Button();
            this.closeNewMeet = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timeNewMeet = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimeNewMeet = new System.Windows.Forms.DateTimePicker();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.deletePatient = new System.Windows.Forms.Button();
            this.writeMessage = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editPatient = new System.Windows.Forms.Button();
            this.newMeet = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listPatients = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteMessage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage1.Controls.Add(this.listMeet);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зустрічі";
            // 
            // listMeet
            // 
            this.listMeet.BackColor = System.Drawing.Color.White;
            this.listMeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMeet.FormattingEnabled = true;
            this.listMeet.ItemHeight = 16;
            this.listMeet.Location = new System.Drawing.Point(7, 6);
            this.listMeet.Name = "listMeet";
            this.listMeet.Size = new System.Drawing.Size(125, 370);
            this.listMeet.TabIndex = 1;
            this.listMeet.SelectedIndexChanged += new System.EventHandler(this.listMeetings_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.deleteMeet);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.editDoctor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(138, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 373);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(82, 101);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(197, 24);
            this.textBox10.TabIndex = 17;
            // 
            // deleteMeet
            // 
            this.deleteMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.deleteMeet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMeet.FlatAppearance.BorderSize = 0;
            this.deleteMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deleteMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMeet.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Trash_can_outline_16;
            this.deleteMeet.Location = new System.Drawing.Point(285, 3);
            this.deleteMeet.Name = "deleteMeet";
            this.deleteMeet.Size = new System.Drawing.Size(27, 25);
            this.deleteMeet.TabIndex = 15;
            this.deleteMeet.UseVisualStyleBackColor = false;
            this.deleteMeet.Click += new System.EventHandler(this.deleteMeet_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(24, 161);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(255, 209);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(82, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 24);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(82, 41);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(197, 24);
            this.textBox7.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ім\'я:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "id:";
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
            this.editDoctor.Location = new System.Drawing.Point(252, 3);
            this.editDoctor.Name = "editDoctor";
            this.editDoctor.Size = new System.Drawing.Size(27, 25);
            this.editDoctor.TabIndex = 2;
            this.editDoctor.UseVisualStyleBackColor = false;
            this.editDoctor.Click += new System.EventHandler(this.editMeet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Примітки:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.listAllPatient);
            this.tabPage2.Controls.Add(this.addPatient);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.listPatients);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(460, 385);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Пацієнти";
            // 
            // listAllPatient
            // 
            this.listAllPatient.BackColor = System.Drawing.Color.White;
            this.listAllPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listAllPatient.FormattingEnabled = true;
            this.listAllPatient.ItemHeight = 16;
            this.listAllPatient.Location = new System.Drawing.Point(7, 6);
            this.listAllPatient.Name = "listAllPatient";
            this.listAllPatient.Size = new System.Drawing.Size(125, 338);
            this.listAllPatient.TabIndex = 9;
            this.listAllPatient.Visible = false;
            this.listAllPatient.SelectedIndexChanged += new System.EventHandler(this.listAllPatients_SelectedIndexChanged);
            // 
            // addPatient
            // 
            this.addPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.addPatient.FlatAppearance.BorderSize = 0;
            this.addPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.addPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.addPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatient.Location = new System.Drawing.Point(7, 349);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(125, 27);
            this.addPatient.TabIndex = 8;
            this.addPatient.Text = "Додати";
            this.addPatient.UseVisualStyleBackColor = false;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.deletePatient);
            this.panel3.Controls.Add(this.writeMessage);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.editPatient);
            this.panel3.Controls.Add(this.newMeet);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(138, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 373);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.createNewMeet);
            this.panel4.Controls.Add(this.closeNewMeet);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.timeNewMeet);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.dateTimeNewMeet);
            this.panel4.Location = new System.Drawing.Point(21, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 168);
            this.panel4.TabIndex = 25;
            this.panel4.Visible = false;
            // 
            // createNewMeet
            // 
            this.createNewMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.createNewMeet.FlatAppearance.BorderSize = 0;
            this.createNewMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.createNewMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.createNewMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewMeet.Location = new System.Drawing.Point(148, 132);
            this.createNewMeet.Name = "createNewMeet";
            this.createNewMeet.Size = new System.Drawing.Size(95, 25);
            this.createNewMeet.TabIndex = 26;
            this.createNewMeet.Text = "Записатися";
            this.createNewMeet.UseVisualStyleBackColor = false;
            this.createNewMeet.Click += new System.EventHandler(this.createNewMeet_Click);
            // 
            // closeNewMeet
            // 
            this.closeNewMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.closeNewMeet.FlatAppearance.BorderSize = 0;
            this.closeNewMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.closeNewMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.closeNewMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeNewMeet.Location = new System.Drawing.Point(13, 132);
            this.closeNewMeet.Name = "closeNewMeet";
            this.closeNewMeet.Size = new System.Drawing.Size(95, 25);
            this.closeNewMeet.TabIndex = 28;
            this.closeNewMeet.Text = "Назад";
            this.closeNewMeet.UseVisualStyleBackColor = false;
            this.closeNewMeet.Click += new System.EventHandler(this.closeNewMeet_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(53, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Оберіть час:";
            // 
            // timeNewMeet
            // 
            this.timeNewMeet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeNewMeet.FormatString = "t";
            this.timeNewMeet.FormattingEnabled = true;
            this.timeNewMeet.Location = new System.Drawing.Point(110, 65);
            this.timeNewMeet.Name = "timeNewMeet";
            this.timeNewMeet.Size = new System.Drawing.Size(133, 24);
            this.timeNewMeet.TabIndex = 25;
            this.timeNewMeet.SelectedIndexChanged += new System.EventHandler(this.timeNewMeet_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Оберіть дату";
            // 
            // dateTimeNewMeet
            // 
            this.dateTimeNewMeet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNewMeet.Location = new System.Drawing.Point(110, 30);
            this.dateTimeNewMeet.MaxDate = new System.DateTime(2023, 4, 26, 17, 57, 1, 810);
            this.dateTimeNewMeet.MinDate = new System.DateTime(2023, 3, 26, 17, 57, 1, 811);
            this.dateTimeNewMeet.Name = "dateTimeNewMeet";
            this.dateTimeNewMeet.Size = new System.Drawing.Size(133, 24);
            this.dateTimeNewMeet.TabIndex = 23;
            this.dateTimeNewMeet.Value = new System.DateTime(2023, 3, 26, 17, 57, 1, 811);
            this.dateTimeNewMeet.ValueChanged += new System.EventHandler(this.dateTimeNewMeet_ValueChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox12.Location = new System.Drawing.Point(24, 171);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox12.Size = new System.Drawing.Size(255, 199);
            this.textBox12.TabIndex = 17;
            // 
            // deletePatient
            // 
            this.deletePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.deletePatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deletePatient.FlatAppearance.BorderSize = 0;
            this.deletePatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deletePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePatient.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Trash_can_outline_16;
            this.deletePatient.Location = new System.Drawing.Point(285, 3);
            this.deletePatient.Name = "deletePatient";
            this.deletePatient.Size = new System.Drawing.Size(27, 25);
            this.deletePatient.TabIndex = 15;
            this.deletePatient.UseVisualStyleBackColor = false;
            this.deletePatient.Click += new System.EventHandler(this.deletePatient_Click);
            // 
            // writeMessage
            // 
            this.writeMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.writeMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.writeMessage.FlatAppearance.BorderSize = 0;
            this.writeMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.writeMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.writeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeMessage.Image = global::OOP.Properties.Resources.Iconsmind_Outline_Email_16;
            this.writeMessage.Location = new System.Drawing.Point(219, 3);
            this.writeMessage.Name = "writeMessage";
            this.writeMessage.Size = new System.Drawing.Size(27, 25);
            this.writeMessage.TabIndex = 14;
            this.writeMessage.UseVisualStyleBackColor = false;
            this.writeMessage.Click += new System.EventHandler(this.writeMessage_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(139, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 24);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(139, 101);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 24);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "По-батькові:";
            // 
            // editPatient
            // 
            this.editPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.editPatient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editPatient.FlatAppearance.BorderSize = 0;
            this.editPatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.editPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPatient.Image = global::OOP.Properties.Resources.Iconsmind_Outline_Pen_3_16;
            this.editPatient.Location = new System.Drawing.Point(252, 3);
            this.editPatient.Name = "editPatient";
            this.editPatient.Size = new System.Drawing.Size(27, 25);
            this.editPatient.TabIndex = 8;
            this.editPatient.UseVisualStyleBackColor = false;
            this.editPatient.Click += new System.EventHandler(this.editPatient_Click);
            // 
            // newMeet
            // 
            this.newMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.newMeet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.newMeet.FlatAppearance.BorderSize = 0;
            this.newMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.newMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.newMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMeet.Location = new System.Drawing.Point(24, 3);
            this.newMeet.Name = "newMeet";
            this.newMeet.Size = new System.Drawing.Size(189, 25);
            this.newMeet.TabIndex = 7;
            this.newMeet.Text = "Зустріч";
            this.newMeet.UseVisualStyleBackColor = false;
            this.newMeet.Click += new System.EventHandler(this.newMeet_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(139, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 24);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(139, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 24);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ім\'я:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "id:";
            // 
            // listPatients
            // 
            this.listPatients.BackColor = System.Drawing.Color.White;
            this.listPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPatients.FormattingEnabled = true;
            this.listPatients.ItemHeight = 16;
            this.listPatients.Location = new System.Drawing.Point(7, 6);
            this.listPatients.Name = "listPatients";
            this.listPatients.Size = new System.Drawing.Size(125, 338);
            this.listPatients.TabIndex = 6;
            this.listPatients.SelectedIndexChanged += new System.EventHandler(this.listPatients_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.deleteMessage);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.send);
            this.tabPage3.Controls.Add(this.listMessage);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 385);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Повідомлення";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(162, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 24);
            this.textBox1.TabIndex = 3;
            // 
            // deleteMessage
            // 
            this.deleteMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.deleteMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMessage.FlatAppearance.BorderSize = 0;
            this.deleteMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deleteMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMessage.Location = new System.Drawing.Point(7, 349);
            this.deleteMessage.Name = "deleteMessage";
            this.deleteMessage.Size = new System.Drawing.Size(125, 27);
            this.deleteMessage.TabIndex = 4;
            this.deleteMessage.Text = "Видалити";
            this.deleteMessage.UseVisualStyleBackColor = false;
            this.deleteMessage.Click += new System.EventHandler(this.deleteMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(138, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 340);
            this.panel2.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox11.Location = new System.Drawing.Point(24, 32);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox11.Size = new System.Drawing.Size(268, 305);
            this.textBox11.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Від:";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Send_16;
            this.send.Location = new System.Drawing.Point(403, 353);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(27, 25);
            this.send.TabIndex = 2;
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.Color.White;
            this.listMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(7, 6);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(125, 338);
            this.listMessage.TabIndex = 2;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessages_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(507, 483);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лікар";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listMeet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteMessage;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listPatients;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button editDoctor;
        private System.Windows.Forms.Button newMeet;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editPatient;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteMeet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button writeMessage;
        private System.Windows.Forms.Button deletePatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button createNewMeet;
        private System.Windows.Forms.Button closeNewMeet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox timeNewMeet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimeNewMeet;
        private System.Windows.Forms.ListBox listAllPatient;
    }
}