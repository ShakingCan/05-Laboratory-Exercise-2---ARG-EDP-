namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            studentnobox = new TextBox();
            lastnamebox = new TextBox();
            agebox = new TextBox();
            firstnamebox = new TextBox();
            contactnobox = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            genderbox = new ComboBox();
            programbox = new ComboBox();
            label10 = new Label();
            mibox = new TextBox();
            registerbtn = new Button();
            recordsbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Student no.";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(52, 112);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(83, 143);
            label4.Name = "label4";
            label4.Size = new Size(31, 17);
            label4.TabIndex = 3;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(59, 175);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(349, 82);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(354, 143);
            label7.Name = "label7";
            label7.Size = new Size(57, 19);
            label7.TabIndex = 6;
            label7.Text = "Gender:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(345, 112);
            label8.Name = "label8";
            label8.Size = new Size(73, 19);
            label8.TabIndex = 7;
            label8.Text = "First name";
            // 
            // studentnobox
            // 
            studentnobox.Location = new Point(125, 82);
            studentnobox.Name = "studentnobox";
            studentnobox.Size = new Size(171, 23);
            studentnobox.TabIndex = 8;
            // 
            // lastnamebox
            // 
            lastnamebox.Location = new Point(125, 111);
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(171, 23);
            lastnamebox.TabIndex = 9;
            // 
            // agebox
            // 
            agebox.Location = new Point(125, 140);
            agebox.Name = "agebox";
            agebox.Size = new Size(171, 23);
            agebox.TabIndex = 10;
            // 
            // firstnamebox
            // 
            firstnamebox.Location = new Point(415, 112);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.Size = new Size(171, 23);
            firstnamebox.TabIndex = 12;
            // 
            // contactnobox
            // 
            contactnobox.Location = new Point(440, 175);
            contactnobox.Name = "contactnobox";
            contactnobox.Size = new Size(171, 23);
            contactnobox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(354, 175);
            label9.Name = "label9";
            label9.Size = new Size(80, 19);
            label9.TabIndex = 14;
            label9.Text = "Contact no.";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // genderbox
            // 
            genderbox.FormattingEnabled = true;
            genderbox.Items.AddRange(new object[] { "Male", "Female" });
            genderbox.Location = new Point(417, 143);
            genderbox.Name = "genderbox";
            genderbox.Size = new Size(139, 23);
            genderbox.TabIndex = 16;
            // 
            // programbox
            // 
            programbox.FormattingEnabled = true;
            programbox.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Engineering", "BS in Business Administration", "BS in Tourism" });
            programbox.Location = new Point(415, 82);
            programbox.Name = "programbox";
            programbox.Size = new Size(319, 23);
            programbox.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(613, 113);
            label10.Name = "label10";
            label10.Size = new Size(32, 19);
            label10.TabIndex = 19;
            label10.Text = "M.I.";
            // 
            // mibox
            // 
            mibox.Location = new Point(651, 113);
            mibox.Name = "mibox";
            mibox.Size = new Size(60, 23);
            mibox.TabIndex = 20;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(323, 215);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(88, 36);
            registerbtn.TabIndex = 22;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // recordsbtn
            // 
            recordsbtn.Location = new Point(646, 215);
            recordsbtn.Name = "recordsbtn";
            recordsbtn.Size = new Size(88, 36);
            recordsbtn.TabIndex = 23;
            recordsbtn.Text = "Records";
            recordsbtn.UseVisualStyleBackColor = true;
            recordsbtn.Click += recordsbtn_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 271);
            Controls.Add(recordsbtn);
            Controls.Add(registerbtn);
            Controls.Add(mibox);
            Controls.Add(label10);
            Controls.Add(programbox);
            Controls.Add(genderbox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(contactnobox);
            Controls.Add(firstnamebox);
            Controls.Add(agebox);
            Controls.Add(lastnamebox);
            Controls.Add(studentnobox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            Load += FrmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox studentnobox;
        private TextBox lastnamebox;
        private TextBox agebox;
        private TextBox firstnamebox;
        private TextBox contactnobox;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private ComboBox genderbox;
        private ComboBox programbox;
        private Label label10;
        private TextBox mibox;
        private Button registerbtn;
        private Button recordsbtn;
    }
}