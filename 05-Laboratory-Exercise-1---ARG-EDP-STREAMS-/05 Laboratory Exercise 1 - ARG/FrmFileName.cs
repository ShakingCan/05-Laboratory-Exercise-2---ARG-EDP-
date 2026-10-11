using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmFileName : Form
    {
       
        
        public static string SetFileName = "";
        public FrmFileName()
        {


            InitializeComponent();

        }

        private void okaybtn_Click(object sender, EventArgs e)
        {
            SetFileName = filenamebox.Text + ".txt";
            if (!string.IsNullOrWhiteSpace(filenamebox.Text))
                Name = filenamebox.Text;
           
            this.Hide();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {
         
        }
    }
}
