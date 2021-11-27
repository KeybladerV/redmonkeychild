using System.ComponentModel;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.classList = new System.Windows.Forms.ListBox();
            this.studentList = new System.Windows.Forms.ListBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.reputationLabel = new System.Windows.Forms.Label();
            this.removeClassButton = new System.Windows.Forms.Button();
            this.addReputationButton = new System.Windows.Forms.Button();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.reputationTextBox = new System.Windows.Forms.TextBox();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.repaRollerButton = new System.Windows.Forms.Button();
            this.addReputationTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.addReputationTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(711, 419);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(77, 19);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(628, 419);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 19);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // classList
            // 
            this.classList.FormattingEnabled = true;
            this.classList.Location = new System.Drawing.Point(12, 12);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(120, 381);
            this.classList.TabIndex = 2;
            this.classList.SelectedIndexChanged += new System.EventHandler(this.classList_SelectedIndexChanged);
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(138, 12);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(120, 381);
            this.studentList.TabIndex = 3;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(12, 399);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(120, 19);
            this.addClassButton.TabIndex = 4;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(138, 399);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(120, 19);
            this.addStudent.TabIndex = 5;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Location = new System.Drawing.Point(295, 12);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(100, 23);
            this.firstnameLabel.TabIndex = 6;
            this.firstnameLabel.Text = "First Name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Location = new System.Drawing.Point(401, 12);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(100, 23);
            this.lastnameLabel.TabIndex = 7;
            this.lastnameLabel.Text = "Last Name";
            // 
            // reputationLabel
            // 
            this.reputationLabel.Location = new System.Drawing.Point(507, 12);
            this.reputationLabel.Name = "reputationLabel";
            this.reputationLabel.Size = new System.Drawing.Size(100, 23);
            this.reputationLabel.TabIndex = 8;
            this.reputationLabel.Text = "Reputation";
            // 
            // removeClassButton
            // 
            this.removeClassButton.Location = new System.Drawing.Point(12, 424);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(120, 19);
            this.removeClassButton.TabIndex = 9;
            this.removeClassButton.Text = "Remove Class";
            this.removeClassButton.UseVisualStyleBackColor = true;
            this.removeClassButton.Click += new System.EventHandler(this.removeClassButton_Click);
            // 
            // addReputationButton
            // 
            this.addReputationButton.Location = new System.Drawing.Point(668, 374);
            this.addReputationButton.Name = "addReputationButton";
            this.addReputationButton.Size = new System.Drawing.Size(120, 19);
            this.addReputationButton.TabIndex = 11;
            this.addReputationButton.Text = "Add Reputation";
            this.addReputationButton.UseVisualStyleBackColor = true;
            this.addReputationButton.Click += new System.EventHandler(this.addReputationButton_Click);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(295, 38);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.ReadOnly = true;
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 12;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(401, 38);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.ReadOnly = true;
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 13;
            // 
            // reputationTextBox
            // 
            this.reputationTextBox.Location = new System.Drawing.Point(507, 38);
            this.reputationTextBox.Name = "reputationTextBox";
            this.reputationTextBox.ReadOnly = true;
            this.reputationTextBox.Size = new System.Drawing.Size(100, 20);
            this.reputationTextBox.TabIndex = 14;
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(138, 424);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(120, 19);
            this.removeStudentButton.TabIndex = 17;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // repaRollerButton
            // 
            this.repaRollerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.repaRollerButton.Location = new System.Drawing.Point(367, 144);
            this.repaRollerButton.Name = "repaRollerButton";
            this.repaRollerButton.Size = new System.Drawing.Size(338, 122);
            this.repaRollerButton.TabIndex = 18;
            this.repaRollerButton.Text = "REPA ROLLER";
            this.repaRollerButton.UseVisualStyleBackColor = true;
            this.repaRollerButton.Click += new System.EventHandler(this.repaRollerButton_Click);
            // 
            // addReputationTextBox
            // 
            this.addReputationTextBox.Location = new System.Drawing.Point(668, 348);
            this.addReputationTextBox.Minimum = new decimal(new int[] {100, 0, 0, -2147483648});
            this.addReputationTextBox.Name = "addReputationTextBox";
            this.addReputationTextBox.Size = new System.Drawing.Size(120, 20);
            this.addReputationTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addReputationTextBox);
            this.Controls.Add(this.repaRollerButton);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.reputationTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.addReputationButton);
            this.Controls.Add(this.removeClassButton);
            this.Controls.Add(this.reputationLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Students Repa";
            ((System.ComponentModel.ISupportInitialize) (this.addReputationTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown addReputationTextBox;

        private System.Windows.Forms.Button repaRollerButton;

        private System.Windows.Forms.Button removeStudentButton;

        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox reputationTextBox;

        private System.Windows.Forms.Button addReputationButton;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Button removeClassButton;
        private System.Windows.Forms.Label reputationLabel;

        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.ListBox classList;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox studentList;

        private System.Windows.Forms.Button loadButton;

        #endregion
    }
}