namespace CivilWarProject
{
    partial class frmPreGame
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
            this.dgvLeaderBoard = new System.Windows.Forms.DataGridView();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.rdbScore = new System.Windows.Forms.RadioButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaderBoard
            // 
            this.dgvLeaderBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvLeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderBoard.GridColor = System.Drawing.Color.Black;
            this.dgvLeaderBoard.Location = new System.Drawing.Point(242, 44);
            this.dgvLeaderBoard.Name = "dgvLeaderBoard";
            this.dgvLeaderBoard.Size = new System.Drawing.Size(223, 269);
            this.dgvLeaderBoard.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(26, 136);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(195, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(26, 207);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(195, 49);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // rdbScore
            // 
            this.rdbScore.AutoSize = true;
            this.rdbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbScore.Location = new System.Drawing.Point(249, 10);
            this.rdbScore.Name = "rdbScore";
            this.rdbScore.Size = new System.Drawing.Size(123, 21);
            this.rdbScore.TabIndex = 3;
            this.rdbScore.TabStop = true;
            this.rdbScore.Text = "Number of wins";
            this.rdbScore.UseVisualStyleBackColor = true;
            this.rdbScore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbScore_MouseClick);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbName.Location = new System.Drawing.Point(378, 10);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(63, 21);
            this.rdbName.TabIndex = 4;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Name";
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbName_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Location = new System.Drawing.Point(-2, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 322);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CivilWarProject.Properties.Resources.CivilWar1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmPreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(464, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbName);
            this.Controls.Add(this.rdbScore);
            this.Controls.Add(this.dgvLeaderBoard);
            this.Name = "frmPreGame";
            this.Text = "frmPreGame";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaderBoard;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.RadioButton rdbScore;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}