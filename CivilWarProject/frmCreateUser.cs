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
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User newUser = new User(txtUsername.Text, txtPassword.Text, txtEmail.Text);
            
        }
    }
}
