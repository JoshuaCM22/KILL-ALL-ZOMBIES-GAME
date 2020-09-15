namespace KILL_ALL_ZOMBIES_GAME.Forms
{
    partial class Form_DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DialogBox));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(59, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GAME OVER";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(74, 110);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(297, 29);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "Do you want to play again?";
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYes.ForeColor = System.Drawing.Color.White;
            this.lblYes.Location = new System.Drawing.Point(124, 20);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(53, 25);
            this.lblYes.TabIndex = 0;
            this.lblYes.Text = "Yes";
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            this.lblYes.MouseLeave += new System.EventHandler(this.lblYes_MouseLeave);
            this.lblYes.MouseHover += new System.EventHandler(this.lblYes_MouseHover);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(259, 20);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 25);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "No";
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            this.lblNo.MouseLeave += new System.EventHandler(this.lblNo_MouseLeave);
            this.lblNo.MouseHover += new System.EventHandler(this.lblNo_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblYes);
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Location = new System.Drawing.Point(-3, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 96);
            this.panel1.TabIndex = 1;
            // 
            // Form_DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 247);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_DialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_DialogBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Panel panel1;
    }
}