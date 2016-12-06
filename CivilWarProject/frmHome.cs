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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();


            /*
             * https://www.daniweb.com/programming/software-development/threads/194339/how-can-i-make-a-transparent-label-over-a-picturebox
             * 
             * Creating an invisible label,
             * Author: Teme64
             * Date Written: 2009
             * Date Accessed: 06/12/2016
             */
            // Make the lable over sign up invisible, but still usable.
            lblSignUp.Parent = pcbxHomeBG;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.BringToFront();
            lblSignUp.ForeColor = Color.Transparent;

            //Make lable over login Invisible but still usable.
            lblLogIn.Parent = pcbxHomeBG;
            lblLogIn.BackColor = Color.Transparent;
            lblLogIn.BringToFront();
            lblLogIn.ForeColor = Color.Transparent;

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            frmCreateUser nxtFrm = new frmCreateUser(this);

            nxtFrm.Show();
            this.Hide();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            frmLogIn nxtFrm = new frmLogIn(this);

            nxtFrm.Show();
            this.Hide();
        }
    }
}
