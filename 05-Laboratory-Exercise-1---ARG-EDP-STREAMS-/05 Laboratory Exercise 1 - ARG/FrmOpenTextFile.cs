using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmOpenTextFile : Form
    {
        private string path;
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
    }
}
