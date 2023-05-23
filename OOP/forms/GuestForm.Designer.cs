namespace OOP
{
    partial class GuestForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 414);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // doctorSpeciality
            // 
            this.doctorSpeciality.BackColor = System.Drawing.Color.White;
            this.doctorSpeciality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorSpeciality.Enabled = false;
            this.doctorSpeciality.Location = new System.Drawing.Point(149, 166);
            this.doctorSpeciality.Name = "doctorSpeciality";
            this.doctorSpeciality.Size = new System.Drawing.Size(140, 24);
            this.doctorSpeciality.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 172);
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
            this.doctorMiddleName.Location = new System.Drawing.Point(149, 136);
            this.doctorMiddleName.Name = "doctorMiddleName";
            this.doctorMiddleName.Size = new System.Drawing.Size(140, 24);
            this.doctorMiddleName.TabIndex = 30;
            // 
            // doctorLastName
            // 
            this.doctorLastName.BackColor = System.Drawing.Color.White;
            this.doctorLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorLastName.Enabled = false;
            this.doctorLastName.Location = new System.Drawing.Point(149, 106);
            this.doctorLastName.Name = "doctorLastName";
            this.doctorLastName.Size = new System.Drawing.Size(140, 24);
            this.doctorLastName.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Прізвище:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 142);
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
            this.doctorName.Location = new System.Drawing.Point(149, 76);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(140, 24);
            this.doctorName.TabIndex = 26;
            // 
            // doctorId
            // 
            this.doctorId.BackColor = System.Drawing.Color.White;
            this.doctorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doctorId.Enabled = false;
            this.doctorId.Location = new System.Drawing.Point(149, 46);
            this.doctorId.Name = "doctorId";
            this.doctorId.Size = new System.Drawing.Size(140, 24);
            this.doctorId.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ім\'я:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 52);
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
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Реєстрація";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Repeat password";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(142, 229);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 24);
            this.textBox5.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(211)))), ((int)(((byte)(244)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(141)))), ((int)(((byte)(170)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(155, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Зареєструватися";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(142, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 24);
            this.textBox1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(142, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 24);
            this.textBox4.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(489, 436);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(507, 483);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гість";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listDoctor;
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
    }
}