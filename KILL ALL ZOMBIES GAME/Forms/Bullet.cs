using System;
using System.Drawing;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME.Forms // Created by: Joshua C. Magoliman
{ 
    class Bullet
    {
        #region Fields 
        public string bulletDirection = "";
        public int bulletLeft = 0;
        public int bulletTop = 0;
        private int bulletSpeed = 20;
        private PictureBox pbBullet = new PictureBox();
        private Timer timerBullet = new Timer();
        #endregion

        #region Event Handler Methods
        private void BulletTimerEvent(object sender, EventArgs e)
        {
            // If the value of field called bulletDirection is "left".
            if (bulletDirection == "left")
            {
                pbBullet.Left -= bulletSpeed; // Move the bullet to left direction.
            }
            // If the value of field called bulletDirection is "right".
            if (bulletDirection == "right")
            {
                pbBullet.Left += bulletSpeed; // Move the bullet to right direction.
            }
            // If the value of field called bulletDirection is "up".
            if (bulletDirection == "up")
            {
                pbBullet.Top -= bulletSpeed; // Move the bullet to up direction.
            }
            // If the value of field called bulletDirection is "down".
            if (bulletDirection == "down")
            {
                pbBullet.Top += bulletSpeed; // Move the bullet to down direction.
            }
            // If the field called pbBullet has come out in the size of the form.
            if (pbBullet.Left < 10 || pbBullet.Left > 860 || pbBullet.Top < 10 || pbBullet.Top > 600)
            {
                timerBullet.Stop();
                timerBullet.Dispose();
                pbBullet.Dispose();
                timerBullet = null;
                pbBullet = null;
            }
        }
        #endregion

        #region User Defined Methods
        public void MakeBullet(Form param_Form)
        {
            pbBullet.BackColor = Color.Yellow;
            pbBullet.Size = new Size(5, 5);
            pbBullet.Tag = "bullet";
            pbBullet.Left = bulletLeft;
            pbBullet.Top = bulletTop;
            pbBullet.BringToFront();
            param_Form.Controls.Add(pbBullet);
            timerBullet.Interval = bulletSpeed;
            timerBullet.Tick += new EventHandler(BulletTimerEvent);
            timerBullet.Start();
        }
        #endregion
    }
}
