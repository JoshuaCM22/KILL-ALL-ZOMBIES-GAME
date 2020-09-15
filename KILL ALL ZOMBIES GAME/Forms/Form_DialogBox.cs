using System;
using System.Drawing;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME.Forms // Created by: Joshua C. Magoliman
{
    public partial class Form_DialogBox : Form
    {
        #region Constructor 
        public Form_DialogBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handler Methods
        private void Form_DialogBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitle;
        }
        private void lblYes_Click(object sender, EventArgs e)
        {
            UserClickedButton();
            Form_Game nextWindow = new Form_Game();
            nextWindow.ShowDialog();
        }
        private void lblNo_Click(object sender, EventArgs e)
        {
            UserClickedButton();
            Form_Introduction nextWindow = new Form_Introduction();
            nextWindow.ShowDialog();
        }
        private void lblYes_MouseHover(object sender, EventArgs e)
        {
            lblYes.BackColor = Color.Red;
        }
        private void lblYes_MouseLeave(object sender, EventArgs e)
        {
            lblYes.BackColor = Color.DarkRed;
        }
        private void lblNo_MouseHover(object sender, EventArgs e)
        {
            lblNo.BackColor = Color.Red;
        }
        private void lblNo_MouseLeave(object sender, EventArgs e)
        {
            lblNo.BackColor = Color.DarkRed;
        }
        #endregion

        #region User Defined Methods
        private void UserClickedButton()
        {
            Form_Game.isUserChoosen = true;
            this.Hide();
        }
        #endregion 
    }
}
