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
    public partial class frmLogIn : Form
    {
        frmHome parent;
        User LoggingIn;
        public frmLogIn(frmHome parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoggingIn = new User(txtName.Text, txtPassword.Text);

            if (LoggingIn.logIn())
            {
                frmPreGame nxtFrm = new frmPreGame();

                nxtFrm.Show();
                parent.Close();
                this.Close();
            }

            else
                MessageBox.Show("ERROR! INvalid Username and Password combination\nPlease Make sure your details are correct and try again.");
        }
    }
}
