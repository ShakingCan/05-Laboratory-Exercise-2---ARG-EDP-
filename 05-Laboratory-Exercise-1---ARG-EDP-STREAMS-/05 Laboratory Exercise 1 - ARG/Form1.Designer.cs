namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmLab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputbox = new TextBox();
            createbtn = new Button();
            SuspendLayout();
            // 
            // inputbox
            // 
            inputbox.Location = new Point(228, 83);
            inputbox.Multiline = true;
            inputbox.Name = "inputbox";
            inputbox.Size = new Size(316, 125);
            inputbox.TabIndex = 0;
            inputbox.TextChanged += inputbox_TextChanged;
            // 
            // createbtn
            // 
            createbtn.Location = new Point(340, 226);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(90, 33);
            createbtn.TabIndex = 1;
            createbtn.Text = "Create";
            createbtn.UseVisualStyleBackColor = true;
            createbtn.Click += createbtn_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createbtn);
            Controls.Add(inputbox);
            Name = "FrmLab1";
            Size = new Size(765, 363);
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputbox;
        private Button createbtn;
    }
}
