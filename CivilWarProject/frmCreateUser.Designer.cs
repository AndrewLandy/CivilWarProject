namespace CivilWarProject
{
    partial class frmCreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "User Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(100, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Please Enter a Name!";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.CausesValidation = false;
            this.txtPassword.Location = new System.Drawing.Point(100, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Please Enter an E-mail Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(107, 174);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 310);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblName);
            this.Name = "frmCreateUser";
            this.Text = "frmCreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSubmit;
    }
}