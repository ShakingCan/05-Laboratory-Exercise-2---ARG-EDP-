namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmStudentRecord
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            openFileDialog1 = new OpenFileDialog();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 1;
            label1.Text = "View record";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(675, 41);
            button2.Name = "button2";
            button2.Size = new Size(81, 30);
            button2.TabIndex = 3;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(675, 77);
            button3.Name = "button3";
            button3.Size = new Size(81, 30);
            button3.TabIndex = 4;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(675, 113);
            button4.Name = "button4";
            button4.Size = new Size(81, 30);
            button4.TabIndex = 5;
            button4.Text = "Upload";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            listView1.Location = new Point(11, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(658, 272);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 324);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            Load += FrmStudentRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private OpenFileDialog openFileDialog1;
        private ListView listView1;
    }
}