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
            var newStudent = new Student();
            newStudent.StudId = int.Parse(txtId.Text);
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.Address = txtAddress.Text;

            newStudent.Month = (MonthOfAdmission)(comboMonth.SelectedIndex + 1);
            newStudent.Grade = char.Parse(comboGrade.Text);
            Data.Students.Add(newStudent);
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
