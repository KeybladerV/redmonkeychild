using System.ComponentModel;

namespace WinFormsApp1
{
    partial class StudentEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.editFirstnameLabel = new System.Windows.Forms.Label();
            this.editLastnameLabel = new System.Windows.Forms.Label();
            this.editFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.editLastnameTextBox = new System.Windows.Forms.TextBox();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editFirstnameLabel
            // 
            this.editFirstnameLabel.Location = new System.Drawing.Point(12, 9);
            this.editFirstnameLabel.Name = "editFirstnameLabel";
            this.editFirstnameLabel.Size = new System.Drawing.Size(100, 23);
            this.editFirstnameLabel.TabIndex = 0;
            this.editFirstnameLabel.Text = "First Name";
            // 
            // editLastnameLabel
            // 
            this.editLastnameLabel.Location = new System.Drawing.Point(12, 32);
            this.editLastnameLabel.Name = "editLastnameLabel";
            this.editLastnameLabel.Size = new System.Drawing.Size(100, 23);
            this.editLastnameLabel.TabIndex = 1;
            this.editLastnameLabel.Text = "Last Name";
            // 
            // editFirstnameTextBox
            // 
            this.editFirstnameTextBox.Location = new System.Drawing.Point(118, 6);
            this.editFirstnameTextBox.Name = "editFirstnameTextBox";
            this.editFirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editFirstnameTextBox.TabIndex = 2;
            this.editFirstnameTextBox.TextChanged += new System.EventHandler(this.editFirstnameTextBox_TextChanged);
            // 
            // editLastnameTextBox
            // 
            this.editLastnameTextBox.Location = new System.Drawing.Point(118, 30);
            this.editLastnameTextBox.Name = "editLastnameTextBox";
            this.editLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editLastnameTextBox.TabIndex = 3;
            this.editLastnameTextBox.TextChanged += new System.EventHandler(this.editLastnameTextBox_TextChanged);
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.Location = new System.Drawing.Point(143, 68);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(75, 23);
            this.updateStudentButton.TabIndex = 4;
            this.updateStudentButton.Text = "Save";
            this.updateStudentButton.UseVisualStyleBackColor = true;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 103);
            this.Controls.Add(this.updateStudentButton);
            this.Controls.Add(this.editLastnameTextBox);
            this.Controls.Add(this.editFirstnameTextBox);
            this.Controls.Add(this.editLastnameLabel);
            this.Controls.Add(this.editFirstnameLabel);
            this.Name = "StudentEdit";
            this.Text = "Student Edit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label editFirstnameLabel;
        private System.Windows.Forms.TextBox editFirstnameTextBox;
        private System.Windows.Forms.Label editLastnameLabel;
        private System.Windows.Forms.TextBox editLastnameTextBox;
        private System.Windows.Forms.Button updateStudentButton;

        #endregion
    }
}