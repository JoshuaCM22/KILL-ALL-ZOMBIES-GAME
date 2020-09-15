using System;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME.Forms  // Created by: Joshua C. Magoliman
{
    public partial class Form_HighKills : Form
    {
        #region Fields    
        private CustomAudio customAudio = new CustomAudio("introduction_and_in_game.wav");
        #endregion

        #region Constructor       
        public Form_HighKills()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler Methods
        private void Form_HighScores_Load(object sender, EventArgs e)
        {
            CheckIfAudioMutedOrNot();
            Top10Only.Show(this.lblRankHeaderAndContent, this.lblDateHeaderAndContent, this.lblKillHeaderAndContent);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            customAudio.StopPlaying();
            this.Hide();
            Form_Introduction nextForm = new Form_Introduction();
            nextForm.Show();
        }
        private void Form_HighKills_FormClosed(object sender, FormClosedEventArgs e)
        {
            customAudio.StopPlaying();
            Application.Exit();
        }
        #endregion

        #region User Defined Methods
        private void CheckIfAudioMutedOrNot()
        {
            if (Form_Introduction.isAudioOn == true)
            {
                customAudio.Play(true);
            }
        }
        #endregion   
    }
}
