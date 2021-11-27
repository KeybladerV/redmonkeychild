using System;
using System.Windows.Forms;
using StudentReputation;

namespace WinFormsApp1
{
    public partial class ClassEdit : Form
    {
        public ClassEdit()
        {
            InitializeComponent();
        }

        private void editClassSaveButton_Click(object sender, EventArgs e)
        {
            if (editClassNameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Name must be 3 or longer symbols", "Class Name Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentClass studentClass = new() {Name = editClassNameTextBox.Text};
            Form1.Obj.ClassList.Add(studentClass);

            MessageBox.Show("Class Saved!", "Class Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}