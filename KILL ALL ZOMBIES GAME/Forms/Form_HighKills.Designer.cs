namespace KILL_ALL_ZOMBIES_GAME.Forms
{
    partial class Form_HighKills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HighKills));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRankHeaderAndContent = new System.Windows.Forms.Label();
            this.lblDateHeaderAndContent = new System.Windows.Forms.Label();
            this.lblKillHeaderAndContent = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTop10Only = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(208, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HIGH KILLS";
            // 
            // lblRankHeaderAndContent
            // 
            this.lblRankHeaderAndContent.AutoSize = true;
            this.lblRankHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRankHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblRankHeaderAndContent.Location = new System.Drawing.Point(79, 148);
            this.lblRankHeaderAndContent.Name = "lblRankHeaderAndContent";
            this.lblRankHeaderAndContent.Size = new System.Drawing.Size(62, 25);
            this.lblRankHeaderAndContent.TabIndex = 0;
            this.lblRankHeaderAndContent.Text = "Rank";
            // 
            // lblDateHeaderAndContent
            // 
            this.lblDateHeaderAndContent.AutoSize = true;
            this.lblDateHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblDateHeaderAndContent.Location = new System.Drawing.Point(254, 148);
            this.lblDateHeaderAndContent.Name = "lblDateHeaderAndContent";
            this.lblDateHeaderAndContent.Size = new System.Drawing.Size(93, 25);
            this.lblDateHeaderAndContent.TabIndex = 0;
            this.lblDateHeaderAndContent.Text = "      Date";
            // 
            // lblKillHeaderAndContent
            // 
            this.lblKillHeaderAndContent.AutoSize = true;
            this.lblKillHeaderAndContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKillHeaderAndContent.ForeColor = System.Drawing.Color.White;
            this.lblKillHeaderAndContent.Location = new System.Drawing.Point(480, 148);
            this.lblKillHeaderAndContent.Name = "lblKillHeaderAndContent";
            this.lblKillHeaderAndContent.Size = new System.Drawing.Size(41, 25);
            this.lblKillHeaderAndContent.TabIndex = 0;
            this.lblKillHeaderAndContent.Text = "Kill";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(26, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 44);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTop10Only
            // 
            this.lblTop10Only.AutoSize = true;
            this.lblTop10Only.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTop10Only.ForeColor = System.Drawing.Color.Red;
            this.lblTop10Only.Location = new System.Drawing.Point(233, 84);
            this.lblTop10Only.Name = "lblTop10Only";
            this.lblTop10Only.Size = new System.Drawing.Size(155, 29);
            this.lblTop10Only.TabIndex = 0;
            this.lblTop10Only.Text = "Top 10 Only";
            // 
            // Form_HighKills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(614, 575);
            this.Controls.Add(this.lblTop10Only);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKillHeaderAndContent);
            this.Controls.Add(this.lblDateHeaderAndContent);
            this.Controls.Add(this.lblRankHeaderAndContent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_HighKills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KILL ALL ZOMBIES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_HighKills_FormClosed);
            this.Load += new System.EventHandler(this.Form_HighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRankHeaderAndContent;
        private System.Windows.Forms.Label lblDateHeaderAndContent;
        private System.Windows.Forms.Label lblKillHeaderAndContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTop10Only;
    }
}