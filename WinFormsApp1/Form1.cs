using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentReputation;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ClassList _classList;

        private List<Control> _studControls;

        public Form1()
        {
            InitializeComponent();
            _classList = SaveLoader.Load(out bool isNew);

            _studControls = new List<Control>
            {
                firstnameLabel, lastnameLabel, reputationLabel,
                firstnameTextBox, lastnameTextBox, reputationTextBox,
                addReputationButton, addReputationTextBox
            };
            if (isNew)
            {
                _studControls.ForEach(x => x.Visible = false);
                studentList.Visible = Visible;
            }
        }

        private void classList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void removeClassButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addReputationButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void addReputationTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}