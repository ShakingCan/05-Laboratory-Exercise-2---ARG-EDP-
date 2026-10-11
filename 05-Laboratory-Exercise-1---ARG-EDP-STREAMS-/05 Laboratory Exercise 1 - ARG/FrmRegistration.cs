using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmRegistration : Form
    {
        String studno;
        String lastname;
        String firstname;
        int age;
        String MI;
        String birthday;
        String program;
        String gender;
        String contactno;
        FrmStudentRecord record;

        FrmOpenTextFile FrmOpenTextFile;

        public FrmRegistration()
        {
            InitializeComponent();
            FrmOpenTextFile = new FrmOpenTextFile();
            record = new FrmStudentRecord();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            try
            {

                studno = studentnobox.Text;
                lastname = lastnamebox.Text;
                firstname = firstnamebox.Text;
                age = Convert.ToInt32(agebox.Text);
                birthday = dateTimePicker1.Text;
                program = programbox.Text;
                gender = genderbox.Text;
                contactno = contactnobox.Text;
                MI = mibox.Text;

                if (!Regex.IsMatch(contactno, "^09?(\\d{9})"))
                {
                    MessageBox.Show("Invalid Contact number!");
                    return;
                }
                if (!Regex.IsMatch(studno, @"(\d)"))
                {
                    MessageBox.Show("Invalid student number!");
                    return;
                }
                if (String.IsNullOrWhiteSpace(firstnamebox.Text) || String.IsNullOrWhiteSpace(lastnamebox.Text) || String.IsNullOrWhiteSpace(mibox.Text) || String.IsNullOrWhiteSpace(genderbox.Text) || String.IsNullOrWhiteSpace(contactnobox.Text) || String.IsNullOrWhiteSpace(agebox.Text) || String.IsNullOrWhiteSpace(programbox.Text) || String.IsNullOrWhiteSpace(studentnobox.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
                if (mibox.Text.Length > 2)
                {
                    MessageBox.Show("Invalid MI count");
                    return;
                }
                if (!Regex.IsMatch(firstname, @"^[a-zA-Z]+$") || !Regex.IsMatch(lastname, @"^[a-zA-Z]+$") || !Regex.IsMatch(firstname, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Invalid. Names can only be letters");
                    return;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {

                outputFile.WriteLine("Student no: " + studno);
                outputFile.WriteLine("Full name: " + firstname + " " + MI + " " + lastname);
                outputFile.WriteLine("Program: " + program);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Age: " + age);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact no: " + contactno);

            }
            MessageBox.Show("File content updated");
            
            
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void recordsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
