namespace KILL_ALL_ZOMBIES_GAME.Forms
{
    partial class Form_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.pbHealthBar = new System.Windows.Forms.ProgressBar();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.timerGameStart = new System.Windows.Forms.Timer(this.components);
            this.timerGameOver = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmmo.ForeColor = System.Drawing.Color.White;
            this.lblAmmo.Location = new System.Drawing.Point(21, 11);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(93, 24);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKills.ForeColor = System.Drawing.Color.White;
            this.lblKills.Location = new System.Drawing.Point(366, 11);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(71, 24);
            this.lblKills.TabIndex = 0;
            this.lblKills.Text = "Kills: 0";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(631, 11);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(82, 24);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "Health: ";
            // 
            // pbHealthBar
            // 
            this.pbHealthBar.Location = new System.Drawing.Point(719, 11);
            this.pbHealthBar.Name = "pbHealthBar";
            this.pbHealthBar.Size = new System.Drawing.Size(180, 23);
            this.pbHealthBar.TabIndex = 1;
            this.pbHealthBar.Value = 100;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(436, 528);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(71, 100);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // timerGameStart
            // 
            this.timerGameStart.Enabled = true;
            this.timerGameStart.Interval = 20;
            this.timerGameStart.Tick += new System.EventHandler(this.timerGameStart_Tick);
            // 
            // timerGameOver
            // 
            this.timerGameOver.Enabled = true;
            this.timerGameOver.Interval = 20;
            this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbHealthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KILL ALL ZOMBIES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar pbHealthBar;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerGameStart;
        private System.Windows.Forms.Timer timerGameOver;
    }
}