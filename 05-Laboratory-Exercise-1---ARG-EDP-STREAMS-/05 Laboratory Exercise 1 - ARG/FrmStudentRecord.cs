using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmStudentRecord : Form
    {
        String path;

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistration s = new FrmRegistration();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Succesfully uploaded");
            if (listView1 != null)
            {
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No records to upload.");
            }
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\Documents";
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
                    listView1.Items.Add(_getText);
                }
            }
        }
    }
}
