namespace KILL_ALL_ZOMBIES_GAME.Forms
{
    partial class Form_Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Introduction));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnHighKills = new System.Windows.Forms.Button();
            this.pbAudio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(166, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(619, 73);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KILL ALL ZOMBIES";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(94, 261);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(742, 96);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(248, 390);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(387, 120);
            this.lblControls.TabIndex = 0;
            this.lblControls.Text = "Controls: Left Arrow Key = move left\r\n               Right Arrow Key = move right" +
    "\r\n               Up Arrow Key = move up\r\n               Down Arrow Key = move do" +
    "wn\r\n               Spacebar = shoot";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkRed;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(364, 542);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(179, 44);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(416, 132);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(71, 100);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // btnHighKills
            // 
            this.btnHighKills.BackColor = System.Drawing.Color.DarkRed;
            this.btnHighKills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighKills.FlatAppearance.BorderSize = 0;
            this.btnHighKills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighKills.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHighKills.ForeColor = System.Drawing.Color.White;
            this.btnHighKills.Location = new System.Drawing.Point(364, 605);
            this.btnHighKills.Name = "btnHighKills";
            this.btnHighKills.Size = new System.Drawing.Size(179, 44);
            this.btnHighKills.TabIndex = 0;
            this.btnHighKills.TabStop = false;
            this.btnHighKills.Text = "HIGH KILLS";
            this.btnHighKills.UseVisualStyleBackColor = false;
            this.btnHighKills.Click += new System.EventHandler(this.btnHighKills_Click);
            // 
            // pbAudio
            // 
            this.pbAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAudio.Image = ((System.Drawing.Image)(resources.GetObject("pbAudio.Image")));
            this.pbAudio.Location = new System.Drawing.Point(860, 627);
            this.pbAudio.Name = "pbAudio";
            this.pbAudio.Size = new System.Drawing.Size(57, 50);
            this.pbAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAudio.TabIndex = 3;
            this.pbAudio.TabStop = false;
            this.pbAudio.Click += new System.EventHandler(this.pbAudio_Click);
            // 
            // Form_Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(924, 681);
            this.Controls.Add(this.pbAudio);
            this.Controls.Add(this.btnHighKills);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Introduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KILL ALL ZOMBIES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Introduction_FormClosed);
            this.Load += new System.EventHandler(this.Form_Introduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnHighKills;
        private System.Windows.Forms.PictureBox pbAudio;
    }
}