using System;
using System.Windows.Forms;
using StudentReputation;

namespace WinFormsApp1
{
    public partial class RepaRoller : Form
    {
        public StudentClass Selected;

        public RepaRoller()
        {
            InitializeComponent();
        }

        private void repaRollerRollButton_Click(object sender, EventArgs e)
        {
            var winner = ReputationRoller.RollLuck(Selected);
            winnerName.Text = winner != null ? $@"{winner} {winner.Reputation}" : $"NO WINNERS!";
        }
    }
}