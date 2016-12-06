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
    public partial class frmCreateUser : Form
    {
        private frmHome parent;

        public frmCreateUser(frmHome parent)
        {
            InitializeComponent();
            this.parent = parent;

            //Making picture box the parent
            lblName.Parent = pcbxSignUp;
            lblPassword.Parent = pcbxSignUp;
            lblEmail.Parent = pcbxSignUp;
            //txtUsername.Parent = pcbxSignUp;
            //txtPassword.Parent = pcbxSignUp;
            //txtEmail.Parent = pcbxSignUp;

            // Background of controls to transpernet, mathcing the parent
            lblName.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            //txtUsername.BackColor = Color.Transparent;
            //txtPassword.BackColor = Color.Transparent;
            //txtEmail.BackColor = Color.Transparent;

            //Ensuring controld are infront of parent, making them interactable.
            lblName.BringToFront();
            lblPassword.BringToFront();
            lblEmail.BringToFront();
            //txtUsername.BringToFront();
            //txtPassword.BringToFront();
            //txtEmail.BringToFront();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User newUser = new User(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
