using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CivilWarProject
{
    public partial class frmPreGame : Form
    {
        User leaderBoardControl = new User();

        public frmPreGame()
        {
            InitializeComponent();
            populateLeaderBoard();
        }

        private void populateLeaderBoard()
        {
            dgvLeaderBoard.DataSource = leaderBoardControl.leaderBoardScore().Tables["userAccount"];
        }

        private void rdbName_MouseClick(object sender, MouseEventArgs e)
        {
            dgvLeaderBoard.DataSource = leaderBoardControl.leaderBoardName().Tables["userAccount"];
        }

        private void rdbScore_MouseClick(object sender, MouseEventArgs e)
        {
            dgvLeaderBoard.DataSource = leaderBoardControl.leaderBoardScore().Tables["userAccount"];
        }
    }
}
