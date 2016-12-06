namespace CivilWarProject
{
    partial class frmHome
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
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.pcbxHomeBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxHomeBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignUp
            // 
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Location = new System.Drawing.Point(54, 105);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(85, 30);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLogIn.Location = new System.Drawing.Point(58, 149);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(60, 31);
            this.lblLogIn.TabIndex = 2;
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // pcbxHomeBG
            // 
            this.pcbxHomeBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxHomeBG.Image = global::CivilWarProject.Properties.Resources.YR3_Game_Menu;
            this.pcbxHomeBG.Location = new System.Drawing.Point(0, 0);
            this.pcbxHomeBG.Name = "pcbxHomeBG";
            this.pcbxHomeBG.Size = new System.Drawing.Size(484, 322);
            this.pcbxHomeBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbxHomeBG.TabIndex = 0;
            this.pcbxHomeBG.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 322);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.pcbxHomeBG);
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxHomeBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxHomeBG;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblLogIn;
    }
}