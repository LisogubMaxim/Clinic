using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP
{
    partial class PatientForm
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
            this.editMeet = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.deleteMeet = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createNewMeet = new System.Windows.Forms.Button();
            this.closeNewMeet = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timeNewMeet = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimeNewMeet = new System.Windows.Forms.DateTimePicker();
            this.doctorSpeciality = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.doctorMiddleName = new System.Windows.Forms.TextBox();
            this.doctorLastName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.doctorName = new System.Windows.Forms.TextBox();
            this.doctorId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.newMeet = new System.Windows.Forms.Button();
            this.writeMessage = new System.Windows.Forms.Button();
            this.listDoctor = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteMessage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TextBox();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.editProfile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfileMiddleName = new System.Windows.Forms.TextBox();
            this.ProfileLastName = new System.Windows.Forms.TextBox();
            this.ProfileName = new System.Windows.Forms.TextBox();
            this.ProfileId = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 414);
            this.tabControl1.TabIndex = 1;
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
            this.listMeet.SelectedIndexChanged += new System.EventHandler(this.listMeet_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editMeet);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.deleteMeet);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 373);
            this.panel1.TabIndex = 0;
            // 
            // editMeet
            // 
            this.editMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.editMeet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editMeet.FlatAppearance.BorderSize = 0;
            this.editMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.editMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMeet.Image = global::OOP.Properties.Resources.Iconsmind_Outline_Pen_3_16;
            this.editMeet.Location = new System.Drawing.Point(252, 3);
            this.editMeet.Name = "editMeet";
            this.editMeet.Size = new System.Drawing.Size(27, 25);
            this.editMeet.TabIndex = 19;
            this.editMeet.UseVisualStyleBackColor = false;
            this.editMeet.Click += new System.EventHandler(this.editMeet_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Id:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(82, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 24);
            this.textBox6.TabIndex = 17;
            // 
            // deleteMeet
            // 
            this.deleteMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.deleteMeet.FlatAppearance.BorderSize = 0;
            this.deleteMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deleteMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMeet.Image = global::OOP.Properties.Resources.Pictogrammers_Material_Trash_can_outline_16;
            this.deleteMeet.Location = new System.Drawing.Point(285, 3);
            this.deleteMeet.Name = "deleteMeet";
            this.deleteMeet.Size = new System.Drawing.Size(27, 25);
            this.deleteMeet.TabIndex = 16;
            this.deleteMeet.UseVisualStyleBackColor = false;
            this.deleteMeet.Click += new System.EventHandler(this.deleteMeet_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(82, 101);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 24);
            this.textBox5.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(82, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 24);
            this.textBox3.TabIndex = 14;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(24, 161);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(255, 209);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лікар:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.listDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(460, 385);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Лікарі";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.doctorSpeciality);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.doctorMiddleName);
            this.panel3.Controls.Add(this.doctorLastName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.doctorName);
            this.panel3.Controls.Add(this.doctorId);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.newMeet);
            this.panel3.Controls.Add(this.writeMessage);
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
            this.panel4.Location = new System.Drawing.Point(23, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 168);
            this.panel4.TabIndex = 24;
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
            // doctorSpeciality
            // 
            this.doctorSpeciality.BackColor = System.Drawing.Color.White;
            this.doctorSpeciality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorSpeciality.Enabled = false;
            this.doctorSpeciality.Location = new System.Drawing.Point(138, 205);
            this.doctorSpeciality.Name = "doctorSpeciality";
            this.doctorSpeciality.Size = new System.Drawing.Size(140, 24);
            this.doctorSpeciality.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Спеціальність:";
            // 
            // doctorMiddleName
            // 
            this.doctorMiddleName.BackColor = System.Drawing.Color.White;
            this.doctorMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorMiddleName.Enabled = false;
            this.doctorMiddleName.Location = new System.Drawing.Point(138, 175);
            this.doctorMiddleName.Name = "doctorMiddleName";
            this.doctorMiddleName.Size = new System.Drawing.Size(140, 24);
            this.doctorMiddleName.TabIndex = 20;
            // 
            // doctorLastName
            // 
            this.doctorLastName.BackColor = System.Drawing.Color.White;
            this.doctorLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorLastName.Enabled = false;
            this.doctorLastName.Location = new System.Drawing.Point(138, 145);
            this.doctorLastName.Name = "doctorLastName";
            this.doctorLastName.Size = new System.Drawing.Size(140, 24);
            this.doctorLastName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Прізвище:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "По-батькові:";
            // 
            // doctorName
            // 
            this.doctorName.BackColor = System.Drawing.Color.White;
            this.doctorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorName.Enabled = false;
            this.doctorName.Location = new System.Drawing.Point(138, 115);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(140, 24);
            this.doctorName.TabIndex = 16;
            // 
            // doctorId
            // 
            this.doctorId.BackColor = System.Drawing.Color.White;
            this.doctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorId.Enabled = false;
            this.doctorId.Location = new System.Drawing.Point(138, 85);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(140, 24);
            this.doctorId.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Ім\'я:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "id:";
            // 
            // newMeet
            // 
            this.newMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.newMeet.FlatAppearance.BorderSize = 0;
            this.newMeet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.newMeet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.newMeet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newMeet.Location = new System.Drawing.Point(217, 34);
            this.newMeet.Name = "newMeet";
            this.newMeet.Size = new System.Drawing.Size(95, 25);
            this.newMeet.TabIndex = 3;
            this.newMeet.Text = "Зустріч";
            this.newMeet.UseVisualStyleBackColor = false;
            this.newMeet.Click += new System.EventHandler(this.newMeet_Click);
            // 
            // writeMessage
            // 
            this.writeMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.writeMessage.FlatAppearance.BorderSize = 0;
            this.writeMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.writeMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.writeMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeMessage.Location = new System.Drawing.Point(217, 3);
            this.writeMessage.Name = "writeMessage";
            this.writeMessage.Size = new System.Drawing.Size(95, 25);
            this.writeMessage.TabIndex = 2;
            this.writeMessage.Text = "Написати";
            this.writeMessage.UseVisualStyleBackColor = false;
            this.writeMessage.Click += new System.EventHandler(this.writeMessage_Click);
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
            this.listDoctor.TabIndex = 6;
            this.listDoctor.SelectedIndexChanged += new System.EventHandler(this.listDoctor_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage3.Controls.Add(this.send);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.deleteMessage);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.listMessage);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 385);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Повідомлення";
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
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
            this.deleteMessage.FlatAppearance.BorderSize = 0;
            this.deleteMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.deleteMessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.deleteMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMessage.Location = new System.Drawing.Point(7, 352);
            this.deleteMessage.Name = "deleteMessage";
            this.deleteMessage.Size = new System.Drawing.Size(125, 27);
            this.deleteMessage.TabIndex = 5;
            this.deleteMessage.Text = "Видалити";
            this.deleteMessage.UseVisualStyleBackColor = false;
            this.deleteMessage.Click += new System.EventHandler(this.deleteMessage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(138, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 340);
            this.panel2.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox10.Location = new System.Drawing.Point(24, 32);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(268, 305);
            this.textBox10.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(60, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 14;
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
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.tabPage4.Controls.Add(this.About);
            this.tabPage4.Controls.Add(this.radioButtonWomen);
            this.tabPage4.Controls.Add(this.radioButtonMen);
            this.tabPage4.Controls.Add(this.editProfile);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.ProfileMiddleName);
            this.tabPage4.Controls.Add(this.ProfileLastName);
            this.tabPage4.Controls.Add(this.ProfileName);
            this.tabPage4.Controls.Add(this.ProfileId);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(460, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Профіль";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.White;
            this.About.Enabled = false;
            this.About.Location = new System.Drawing.Point(100, 235);
            this.About.Multiline = true;
            this.About.Name = "About";
            this.About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.About.Size = new System.Drawing.Size(262, 132);
            this.About.TabIndex = 17;
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.Enabled = false;
            this.radioButtonWomen.Location = new System.Drawing.Point(294, 196);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(68, 21);
            this.radioButtonWomen.TabIndex = 15;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "Жінка";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Enabled = false;
            this.radioButtonMen.Location = new System.Drawing.Point(200, 196);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(81, 21);
            this.radioButtonMen.TabIndex = 14;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Чоловік";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // editProfile
            // 
            this.editProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.editProfile.FlatAppearance.BorderSize = 0;
            this.editProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.editProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfile.Location = new System.Drawing.Point(400, 3);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(57, 27);
            this.editProfile.TabIndex = 13;
            this.editProfile.Text = "Ред.";
            this.editProfile.UseVisualStyleBackColor = false;
            this.editProfile.Click += new System.EventHandler(this.editProfile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Стать:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "По-батькові:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Прізвище:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ім\'я:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id:";
            // 
            // ProfileMiddleName
            // 
            this.ProfileMiddleName.Enabled = false;
            this.ProfileMiddleName.Location = new System.Drawing.Point(200, 155);
            this.ProfileMiddleName.Name = "ProfileMiddleName";
            this.ProfileMiddleName.Size = new System.Drawing.Size(162, 24);
            this.ProfileMiddleName.TabIndex = 3;
            // 
            // ProfileLastName
            // 
            this.ProfileLastName.Enabled = false;
            this.ProfileLastName.Location = new System.Drawing.Point(200, 115);
            this.ProfileLastName.Name = "ProfileLastName";
            this.ProfileLastName.Size = new System.Drawing.Size(162, 24);
            this.ProfileLastName.TabIndex = 2;
            // 
            // ProfileName
            // 
            this.ProfileName.Enabled = false;
            this.ProfileName.Location = new System.Drawing.Point(200, 75);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(162, 24);
            this.ProfileName.TabIndex = 1;
            // 
            // ProfileId
            // 
            this.ProfileId.Enabled = false;
            this.ProfileId.Location = new System.Drawing.Point(200, 35);
            this.ProfileId.Name = "ProfileId";
            this.ProfileId.Size = new System.Drawing.Size(162, 24);
            this.ProfileId.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(507, 483);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Користувач";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listMeet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listDoctor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newMeet;
        private System.Windows.Forms.Button writeMessage;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button deleteMeet;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox ProfileMiddleName;
        private System.Windows.Forms.TextBox ProfileLastName;
        private System.Windows.Forms.TextBox ProfileName;
        private System.Windows.Forms.TextBox ProfileId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editProfile;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox doctorSpeciality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox doctorMiddleName;
        private System.Windows.Forms.TextBox doctorLastName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox doctorName;
        private System.Windows.Forms.TextBox doctorId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox About;
        private System.Windows.Forms.DateTimePicker dateTimeNewMeet;
        private System.Windows.Forms.Panel panel4;
        private Label label16;
        private Label label17;
        private ComboBox timeNewMeet;
        private Label label18;
        private Button createNewMeet;
        private Button closeNewMeet;
        private Label label4;
        private Label label19;
        private TextBox textBox6;
        private Button editMeet;
    }
}