using System.ComponentModel;

namespace WinFormsApp1
{
    partial class ClassEdit
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
            this.editClassNameLabel = new System.Windows.Forms.Label();
            this.editClassNameTextBox = new System.Windows.Forms.TextBox();
            this.editClassSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editClassNameLabel
            // 
            this.editClassNameLabel.Location = new System.Drawing.Point(12, 9);
            this.editClassNameLabel.Name = "editClassNameLabel";
            this.editClassNameLabel.Size = new System.Drawing.Size(100, 23);
            this.editClassNameLabel.TabIndex = 0;
            this.editClassNameLabel.Text = "Name";
            this.editClassNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editClassNameTextBox
            // 
            this.editClassNameTextBox.Location = new System.Drawing.Point(118, 11);
            this.editClassNameTextBox.Name = "editClassNameTextBox";
            this.editClassNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editClassNameTextBox.TabIndex = 1;
            // 
            // editClassSaveButton
            // 
            this.editClassSaveButton.Location = new System.Drawing.Point(165, 37);
            this.editClassSaveButton.Name = "editClassSaveButton";
            this.editClassSaveButton.Size = new System.Drawing.Size(51, 22);
            this.editClassSaveButton.TabIndex = 2;
            this.editClassSaveButton.Text = "Save";
            this.editClassSaveButton.UseVisualStyleBackColor = true;
            this.editClassSaveButton.Click += new System.EventHandler(this.editClassSaveButton_Click);
            // 
            // ClassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 71);
            this.Controls.Add(this.editClassSaveButton);
            this.Controls.Add(this.editClassNameTextBox);
            this.Controls.Add(this.editClassNameLabel);
            this.Name = "ClassEdit";
            this.Text = "ClassEdit";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox editClassNameTextBox;
        private System.Windows.Forms.Button editClassSaveButton;

        private System.Windows.Forms.Label editClassNameLabel;

        #endregion
    }
}