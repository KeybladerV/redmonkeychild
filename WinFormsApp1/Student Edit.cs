using System;
using System.Windows.Forms;
using StudentReputation;

namespace WinFormsApp1
{
    public partial class StudentEdit : Form
    {
        public int ClassIndex;

        public StudentEdit()
        {
            InitializeComponent();
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            if (editFirstnameTextBox.Text.Length < 3 || editLastnameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Name must be 3 or longer symbols", "Stud Name Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form1.Obj.ClassList.StudentClasses[ClassIndex].Students.Add(new Student
            {
                FirstName = editFirstnameTextBox.Text,
                LastName = editLastnameTextBox.Text,
            });
            
            MessageBox.Show("Stud Saved!", "Stud Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}