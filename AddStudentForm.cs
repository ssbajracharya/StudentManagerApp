using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerApp
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            comboMonth.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Enter a valid number for Student ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.");
                return;
            }
            if (string.IsNullOrEmpty(comboGrade.Text))
            {
                MessageBox.Show("Please select a Grade.");
                return;
            }


            var newStudent = new Student();
            newStudent.StudId = id;
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.Address = txtAddress.Text;

            newStudent.Month = (MonthOfAdmission)(comboMonth.SelectedIndex + 1);
            newStudent.Grade = char.Parse(comboGrade.Text);
            Data.Students.Add(newStudent);
            this.Close();
        }

    }
}
