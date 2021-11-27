using System;
using System.Linq;
using System.Text;
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
            var winners = ReputationRoller.RollLuck(Selected);
            var orderedWinners = winners.OrderByDescending(s => s.Result);
            StringBuilder sb = new();
            foreach (var winner in orderedWinners)
            {
                sb.Append($"{winner.Student} Rep:{winner.Student.Reputation} Score:{winner.Result:F}\n");
            }

            winnerName.Text = sb.ToString();
        }
    }
}