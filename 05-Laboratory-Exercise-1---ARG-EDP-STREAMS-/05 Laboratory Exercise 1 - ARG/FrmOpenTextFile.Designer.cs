namespace _05_Laboratory_Exercise_1___ARG
{
    partial class FrmOpenTextFile
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
            lvShowText = new ListView();
            openbtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.LabelEdit = true;
            lvShowText.Location = new Point(164, 45);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(431, 173);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // openbtn
            // 
            openbtn.Location = new Point(325, 224);
            openbtn.Name = "openbtn";
            openbtn.Size = new Size(75, 23);
            openbtn.TabIndex = 1;
            openbtn.Text = "open";
            openbtn.UseVisualStyleBackColor = true;
            openbtn.Click += openbtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 324);
            Controls.Add(openbtn);
            Controls.Add(lvShowText);
            Name = "FrmOpenTextFile";
            Text = "FrmOpenTextFile";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvShowText;
        private Button openbtn;
        private OpenFileDialog openFileDialog1;
    }
}