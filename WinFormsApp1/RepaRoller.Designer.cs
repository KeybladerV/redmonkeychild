using System.ComponentModel;

namespace WinFormsApp1
{
    partial class RepaRoller
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
            this.winnerName = new System.Windows.Forms.Label();
            this.repaRollerRollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerName
            // 
            this.winnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.winnerName.Location = new System.Drawing.Point(12, 9);
            this.winnerName.Name = "winnerName";
            this.winnerName.Size = new System.Drawing.Size(776, 403);
            this.winnerName.TabIndex = 0;
            this.winnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repaRollerRollButton
            // 
            this.repaRollerRollButton.Location = new System.Drawing.Point(362, 415);
            this.repaRollerRollButton.Name = "repaRollerRollButton";
            this.repaRollerRollButton.Size = new System.Drawing.Size(75, 23);
            this.repaRollerRollButton.TabIndex = 1;
            this.repaRollerRollButton.Text = "Roll";
            this.repaRollerRollButton.UseVisualStyleBackColor = true;
            this.repaRollerRollButton.Click += new System.EventHandler(this.repaRollerRollButton_Click);
            // 
            // RepaRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.repaRollerRollButton);
            this.Controls.Add(this.winnerName);
            this.Name = "RepaRoller";
            this.Text = "RepaRoller";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button repaRollerRollButton;

        private System.Windows.Forms.Label winnerName;

        #endregion
    }
}