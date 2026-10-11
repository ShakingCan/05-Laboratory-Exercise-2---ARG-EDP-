namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmFileName
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
            filenamebox = new TextBox();
            okaybtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(313, 125);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 0;
            label1.Text = "Enter File Name:";
            // 
            // filenamebox
            // 
            filenamebox.Location = new Point(280, 147);
            filenamebox.Name = "filenamebox";
            filenamebox.Size = new Size(172, 23);
            filenamebox.TabIndex = 1;
            // 
            // okaybtn
            // 
            okaybtn.Location = new Point(323, 176);
            okaybtn.Name = "okaybtn";
            okaybtn.Size = new Size(84, 35);
            okaybtn.TabIndex = 2;
            okaybtn.Text = "okay";
            okaybtn.UseVisualStyleBackColor = true;
            okaybtn.Click += okaybtn_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(okaybtn);
            Controls.Add(filenamebox);
            Controls.Add(label1);
            Name = "FrmFileName";
            Size = new Size(765, 363);
            Load += FrmFileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filenamebox;
        private Button okaybtn;
    }
}