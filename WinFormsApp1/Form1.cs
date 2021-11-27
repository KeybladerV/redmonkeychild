using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentReputation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ClassList _classList;

        public ClassList ClassList => _classList;
        public static Form1 Obj;

        private List<Control> _studControls;

        public Form1()
        {
            InitializeComponent();
            _classList = SaveLoader.Load(out bool isNew);
            Obj = this;

            _studControls = new List<Control>
            {
                firstnameLabel, lastnameLabel, reputationLabel,
                firstnameTextBox, lastnameTextBox, reputationTextBox,
                addReputationButton, addReputationTextBox
            };
            if (isNew)
            {
                _studControls.ForEach(x => x.Visible = false);
            }

            classList.DataSource = _classList.StudentClasses;

            _classList.StudentClassesAdd += () =>
            {
                classList.Refresh();
                classList.Update();
            };
            _classList.StudentClassesRemove += () =>
            {
                classList.Refresh();
                classList.Update();
            };
        }

        private void classList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = sender as ListBox;
            studentList.DataSource = ClassList.StudentClasses[list.SelectedIndex].Students;
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stud = studentList.SelectedItem as Student;
            firstnameTextBox.Text = stud.FirstName;
            lastnameTextBox.Text = stud.LastName;
            reputationTextBox.Text = stud.Reputation.ToString();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            ClassEdit classEdit = new();
            classEdit.Show();
        }

        private void removeClassButton_Click(object sender, EventArgs e)
        {
            ClassList.Remove(classList.SelectedIndex);
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            StudentEdit studentEdit = new() {ClassIndex = classList.SelectedIndex};
            studentEdit.Show();
        }

        private void addReputationButton_Click(object sender, EventArgs e)
        {
            if (studentList.SelectedItem is Student stud)
                stud.ReputationChanges.Add(new ReputationChange {DateTime = DateTime.Now, Reputation = (float) addReputationTextBox.Value});
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveLoader.Save(_classList);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var loadedClassList = SaveLoader.Load(out bool isNew);
            if (!isNew)
            {
                _classList = loadedClassList;
                classList.DataSource = _classList.StudentClasses;
            }
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            _classList.StudentClasses[classList.SelectedIndex].Students.RemoveAt(studentList.SelectedIndex);
        }

        private void repaRollerButton_Click(object sender, EventArgs e)
        {
            RepaRoller roller = new() {Selected = classList.SelectedItem as StudentClass};
            roller.Show();
        }
    }
}