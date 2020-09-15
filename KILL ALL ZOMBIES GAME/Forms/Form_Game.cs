using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME.Forms  // Created by: Joshua C. Magoliman
{
    public partial class Form_Game : Form
    {
        #region Fields  
        public static bool isUserChoosen;
        private bool isGoLeft, isGoRight, isGoUp, isGoDown, isGameOver;
        private string currentFacing, dateToday;
        private int playerHealth, playerSpeed, ammo, zombieSpeed, kills;
        Random randomNumber = new Random();
        List<PictureBox> zombiesList = new List<PictureBox>();
        private CustomAudio inGameAudio = new CustomAudio("introduction_and_in_game.wav");
        private CustomAudio gameOverAudio = new CustomAudio("gameover.wav");
        #endregion

        #region Constructor  
        public Form_Game()
        {
            InitializeComponent();
            StartGame();
        }
        #endregion

        #region Event Handler Methods
        private void timerGameStart_Tick(object sender, EventArgs e)
        {
            dateToday = DateTime.Now.ToString("MM/dd/yyyy");
            lblAmmo.Text = "Ammo: " + ammo;
            lblKills.Text = "Kills: " + kills;
            // If the value of the field called playerHealth is greater than 1.
            if (playerHealth > 1)
            {
                pbHealthBar.Value = playerHealth; // Re assign the value of this field called pbHealthBar.
            }
            // Else the value of field called playerHealth is less than 1.
            else
            {
                isGameOver = true; // Re assign the value of this field called isGameOver.
                pbPlayer.Image = Properties.Resources.player_dead;  // Re assign the value of propery image of picturebox called pbPlayer.
            }
            // Player will go to the left side.
            if (isGoLeft == true && pbPlayer.Left > 0)
            {
                pbPlayer.Left -= playerSpeed;
            }
            // Player will go to the right side.
            if (isGoRight == true && pbPlayer.Left + pbPlayer.Width < this.ClientSize.Width)
            {
                pbPlayer.Left += playerSpeed;
            }
            // Player will go to the up side.
            if (isGoUp == true && pbPlayer.Top > 40)
            {
                pbPlayer.Top -= playerSpeed;
            }
            // Player will go to the down side.
            if (isGoDown == true && pbPlayer.Top + pbPlayer.Height < this.ClientSize.Height)
            {
                pbPlayer.Top += playerSpeed;
            }
            // Using the foreach loop to control everything in this form.
            foreach (Control x in this.Controls)
            {
                // Check if there are picturebox that have a tag name of "ammo".
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    // If the picturebox called pbPlayer collided of picturebox with tag name of ammo.
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x); // Remove the picturebox with tag name of ammo in the form.
                        ((PictureBox)x).Dispose(); // Dispose that picturebox.
                        ammo += 5; // Increment the value of the field called ammo by 5.
                        CheckIfAudioMutedOrNot("got_ammo.wav"); // Invoke this user defined method called CheckIfAudioMutedOrNot.
                    }
                }
                // Check if there are picturebox that have a tag name of "zombie".
                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    // If the picturebox called pbPlayer collided of picturebox with tag name of zombie.
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1; // Decrease the field called playerHealth by 1.
                    }
                    // If the player will go to the left side.
                    if (x.Left > pbPlayer.Left)
                    {
                        // The zombie will go to the left side.
                        x.Left -= zombieSpeed;
                        // Re assign the value of propery image of picturebox with tag name of zombie.
                        ((PictureBox)x).Image = Properties.Resources.zombie_left;
                    }
                    // If the player will go to the right side.
                    if (x.Left < pbPlayer.Left)
                    {
                        // The zombie will go to the right side.
                        x.Left += zombieSpeed;
                        // Re assign the value of propery image of picturebox with tag name of zombie.
                        ((PictureBox)x).Image = Properties.Resources.zombie_right;
                    }
                    // If the player will go to the up side.
                    if (x.Top > pbPlayer.Top)
                    {
                        // The zombie will go to the up side.
                        x.Top -= zombieSpeed;
                        // Re assign the value of propery image of picturebox with tag name of zombie.
                        ((PictureBox)x).Image = Properties.Resources.zombie_up;
                    }
                    // If the player will go to the down side.
                    if (x.Top < pbPlayer.Top)
                    {
                        // The zombie will go to the down side.
                        x.Top += zombieSpeed;
                        // Re assign the value of propery image of picturebox with tag name of zombie.
                        ((PictureBox)x).Image = Properties.Resources.zombie_down;
                    }
                }
                // Using the foreach loop to control everything in this form.
                foreach (Control k in this.Controls)
                {
                    // If the picturebox with the tag name of bullet and picturebox with the tag name of zombie. 
                    if (k is PictureBox && (string)k.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        // Both of them are collide.
                        if (x.Bounds.IntersectsWith(k.Bounds))
                        {
                            // Increment the value of field called kills by 1.
                            kills++;
                            // Invoke this user defined method called CheckIfAudioMutedOrNot.
                            CheckIfAudioMutedOrNot("zombie_die.wav");
                            // Remove the picturebox with tag name of bullet in the form.
                            this.Controls.Remove(k);
                            // Dispose that picturebox.
                            ((PictureBox)k).Dispose();
                            // Remove the picturebox with tag name of zombie in the form.
                            this.Controls.Remove(x);
                            // Dispose that picturebox.
                            ((PictureBox)x).Dispose();
                            // Remove that picturebox with tag name of zombie in the list called zombiesList.
                            zombiesList.Remove(((PictureBox)x));
                            // Invoke this user defined method called MakeZombies().
                            MakeZombies();
                        }
                    }
                }
            }
            // If the value of the field called isGameOver is equal to true.
            if (isGameOver == true)
            {
                GameOver();  // Invoke this user defined method called GameOver().
            }
        }
        private void timerGameOver_Tick(object sender, EventArgs e)
        {
            if (isUserChoosen == true)
            {
                this.Hide();
                gameOverAudio.StopPlaying();
                timerGameOver.Stop();
                isUserChoosen = false;
            }
        }
        private void Form_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            inGameAudio.StopPlaying();
            gameOverAudio.StopPlaying();
            Application.Exit();
        }
        // The user is keep pressing.
        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {
            // If the value of field called isGameOver is equal to true.
            if (isGameOver == true)
            {
                return; // End the execution of this Event Handler Method called Form_Game_KeyDown.
            }
            if (e.KeyCode == Keys.Left)
            {
                isGoLeft = true;
                currentFacing = "left";
                pbPlayer.Image = Properties.Resources.player_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                isGoRight = true;
                currentFacing = "right";
                pbPlayer.Image = Properties.Resources.player_right;
            }
            if (e.KeyCode == Keys.Up)
            {
                isGoUp = true;
                currentFacing = "up";
                pbPlayer.Image = Properties.Resources.player_up;
            }
            if (e.KeyCode == Keys.Down)
            {
                isGoDown = true;
                currentFacing = "down";
                pbPlayer.Image = Properties.Resources.player_down;
            }
        }
        // The user releases the touch.
        private void Form_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isGoLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isGoRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                isGoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                isGoDown = false;
            }
            /*
             If user releases the touch of spacebar and the field called ammo the value of greater than zero
             and field called isGameOver the value of false.
            */
            if (e.KeyCode == Keys.Space && ammo > 0 && isGameOver == false)
            {
                ammo--; // Decrease the value of field called ammo by 1.
                ShootBullet(currentFacing); // Invoke this user defined method and passed an arguments.
                CheckIfAudioMutedOrNot("gun_shot.wav"); // Invoke this user defined method and passed an arguments.
                // If the value of the field called ammo is less than 1.
                if (ammo < 1)
                {
                    DropAmmo(); // Invoke this user defined method called DropAmmo().
                }
            }
        }
        #endregion

        #region User Defined Methods
        private void StartGame()
        {
            // Re assign the value of propery image of picturebox called pbPlayer.
            pbPlayer.Image = Properties.Resources.player_up;
            // Using foreach loop to control each picturebox in the list called zombiesList.
            foreach (PictureBox x in zombiesList)
            {
                this.Controls.Remove(x); // Remove every picturebox in the list called zombiesList.
            }
            // Remove all value in the list called zombiesList.
            zombiesList.Clear();
            // Increment 3 times.
            for (int i = 0; i < 3; i++)
            {
                MakeZombies(); // Invoke this user defined method called MakeZombies().
            }
            isGoUp = false;
            isGoDown = false;
            isGoLeft = false;
            isGoRight = false;
            isGameOver = false;
            currentFacing = "up";
            playerHealth = 100;
            playerSpeed = 10;
            zombieSpeed = 3;
            kills = 0;
            ammo = 10;
            timerGameStart.Start();
            dateToday = DateTime.Now.ToString("MM/dd/yyyy");
            PlayInGameAudio();
        }
        private void GameOver()
        {
            inGameAudio.StopPlaying();
            if (Form_Introduction.isAudioOn == true)
            {
                gameOverAudio.Play(false);
            }
            timerGameStart.Stop();
            Top10Only.CheckResultInTop10Only(dateToday, Convert.ToInt32(kills));
            timerGameOver.Start();
            Form_DialogBox nextForm = new Form_DialogBox();
            nextForm.ShowDialog();
        }
        private void PlayInGameAudio()
        {
            if (Form_Introduction.isAudioOn == true)
            {
                inGameAudio.Play(true);
            }
        }
        private void CheckIfAudioMutedOrNot(string param_NameOfWavFile)
        {
            if (Form_Introduction.isAudioOn == true)
            {
                CustomAudio customAudio = new CustomAudio(param_NameOfWavFile);
                customAudio.Play(false);
            }
        }
        private void ShootBullet(string param_Direction)
        {
            Bullet bullet = new Bullet();
            bullet.bulletDirection = param_Direction;
            bullet.bulletLeft = pbPlayer.Left + (pbPlayer.Width / 2);
            bullet.bulletTop = pbPlayer.Top + (pbPlayer.Height / 2);
            bullet.MakeBullet(this);
        }
        private void MakeZombies()
        {
            PictureBox pbZombie = new PictureBox();
            pbZombie.Tag = "zombie";
            pbZombie.Image = Properties.Resources.zombie_down;
            pbZombie.Left = randomNumber.Next(0, 900);
            pbZombie.Top = randomNumber.Next(0, 800);
            pbZombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(pbZombie);
            this.Controls.Add(pbZombie);
            pbPlayer.BringToFront();
        }
        private void DropAmmo()
        {
            PictureBox pbAmmo = new PictureBox();
            pbAmmo.Image = Properties.Resources.ammo;
            pbAmmo.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAmmo.Left = randomNumber.Next(10, this.ClientSize.Width - pbAmmo.Width);
            pbAmmo.Top = randomNumber.Next(60, this.ClientSize.Height - pbAmmo.Height);
            pbAmmo.Tag = "ammo";
            this.Controls.Add(pbAmmo);
            pbAmmo.BringToFront();
            pbPlayer.BringToFront();
        }
        #endregion
    }
}
