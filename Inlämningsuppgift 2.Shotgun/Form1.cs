using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_2.Shotgun
{
    public partial class Form1 : Form
    {
        PlayerInfo player = new PlayerInfo();
        PlayerInfo computer = new PlayerInfo();
        GameLogic gameRules = new GameLogic();

        public Form1()
        {
            InitializeComponent();
            PictureVisibleFalse();
        }
        private async void btnReload_Click(object sender, EventArgs e)
        {
            this.Enabled = false; // Used this.Enabled to handle errors. Before, you could spam-click the button, which caused chaos.
            if (gameRules.CanPlayerPerformAction(ShotgunEnum.Reload, player) == false)
            {
                MessageBox.Show("Du kan inte ladda mer!");
            }
            else
            {
                player.ActiveChoice = ShotgunEnum.Reload;
                computer.ActiveChoice = gameRules.ComputersChoice(computer);
                GameLogic.CheckResult(player, computer); // Sends the instances/choices to a method that checks the result, "CheckResult."         
            }

            await CountdownTimer_Tick(); // These are interface methods to make it look nice.
            PictureDisplayMove(); // These are interface methods to make it look nice.      
            DisplayAmountOfBullets();
            DisplayGameOutcome();
            this.Enabled = true;
        }

        private async void btnShoot_Click(object sender, EventArgs e)
        {
            this.Enabled = false; 
            if (gameRules.CanPlayerPerformAction(ShotgunEnum.Shoot, player) == false)
            {
                MessageBox.Show("Du har inga skott, du måste ladda!");
            }
            else
            {
                player.ActiveChoice = ShotgunEnum.Shoot;
                computer.ActiveChoice = gameRules.ComputersChoice(computer);
                GameLogic.CheckResult(player, computer);
            }

            await CountdownTimer_Tick();
            PictureDisplayMove();
            DisplayAmountOfBullets();
            DisplayGameOutcome();
            this.Enabled = true;
        }

        private async void btnBlock_Click(object sender, EventArgs e)
        {
            this.Enabled = false; 
            player.ActiveChoice = ShotgunEnum.BlockBullet;
            computer.ActiveChoice = gameRules.ComputersChoice(computer);
            GameLogic.CheckResult(player, computer);

            await CountdownTimer_Tick();
            PictureDisplayMove();
            DisplayAmountOfBullets();
            DisplayGameOutcome();
            this.Enabled = true;
        }

        private async void btnShotgun_Click(object sender, EventArgs e)
        {
            this.Enabled = false; 
            if (gameRules.CanPlayerPerformAction(ShotgunEnum.Shotgun, player) == false)
            {
                MessageBox.Show("Du har inte tillräckligt med skott!");
            }
            else
            {
                player.ActiveChoice = ShotgunEnum.Shotgun;
                computer.ActiveChoice = gameRules.ComputersChoice(computer);
                GameLogic.CheckResult(player, computer);             
            }

            await CountdownTimer_Tick();
            PictureDisplayMove();
            DisplayAmountOfBullets();
            DisplayGameOutcome();
            this.Enabled = true;
        }

        public void DisplayAmountOfBullets() // Updates bullet status so the player knows.
        {
            txtSkott.Text = player.AmountBullets.ToString();
            txtSkottDator.Text = computer.AmountBullets.ToString();
        }
        public void DisplayGameOutcome()
        {
            if (computer.WonGame)
            {
                lblLost.Visible = true;
                btnExit.Visible = true;
                btnPlayAgain.Visible = true;
                SetButtons(false);
            }
            if (player.WonGame)
            {
                lblWin.Visible = true;
                btnExit.Visible = true;
                btnPlayAgain.Visible = true;
                SetButtons(false);
            }
        }// Checks if you have won or lost, then shows new text and buttons on the form, e.g., PlayAgain?
        public void PictureVisibleFalse()// This method is used to hide everything when the program starts.
        {
            pictureBoxBlockedComputer.Visible = false;
            pictureBoxReloadComputer.Visible = false;
            pictureBoxShootingComputer.Visible = false;
            pictureBoxShotgunComputer.Visible = false;

            pictureBoxReloadPlayer.Visible = false;
            pictureBoxBlockedPlayer.Visible = false;
            pictureBoxShootingPlayer.Visible = false;
            pictureBoxShotgunPlayer.Visible = false;

            lblLost.Visible = false;
            lblWin.Visible = false;
            btnExit.Visible = false;
            btnPlayAgain.Visible = false;
        }
        public void PictureDisplayMove() // Method that shows images based on the players' choices. If they choose "block," a block icon is displayed
        {
            //if satser för vad Player gör för move
            if (player.ActiveChoice == ShotgunEnum.Reload)
            {
                pictureBoxReloadPlayer.Visible = true;
            }
            else if (player.ActiveChoice == ShotgunEnum.BlockBullet)
            {
                pictureBoxBlockedPlayer.Visible = true;
            }
            else if (player.ActiveChoice == ShotgunEnum.Shoot)
            {
                pictureBoxShootingPlayer.Visible = true;
            }
            else if (player.ActiveChoice == ShotgunEnum.Shotgun)
            {
                pictureBoxShotgunPlayer.Visible = true;
            }

            //if satser för vad computer gör för move
            if (computer.ActiveChoice == ShotgunEnum.Reload)
            {
                pictureBoxReloadComputer.Visible = true;
            }
            else if (computer.ActiveChoice == ShotgunEnum.BlockBullet)
            {
                pictureBoxBlockedComputer.Visible = true;
            }
            else if (computer.ActiveChoice == ShotgunEnum.Shoot)
            {
                pictureBoxShootingComputer.Visible = true;
            }
            else if (computer.ActiveChoice == ShotgunEnum.Shotgun)
            {
                pictureBoxShotgunComputer.Visible = true;
            }
        }

        public async Task CountdownTimer_Tick() // After clicking something, the program waits for 1 second.
        {
            PictureVisibleFalse();
            progressBar1.Value = 0;
            progressBar1.Value = 100;
            await Task.Delay(1000);
        }

        public void ResetGame() // Resets all variables and images.
        {
            player.Reset();
            computer.Reset();
            PictureVisibleFalse();
            DisplayAmountOfBullets();
            SetButtons(true);
        }

        public void SetButtons(bool onOff) // Method to enable/disable buttons with a boolean onOff.
        {
            btnReload.Enabled = onOff;
            btnBlock.Enabled = onOff;
            btnShoot.Enabled = onOff;
            btnShotgun.Enabled = onOff;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
