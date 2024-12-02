namespace Inlämningsuppgift_2.Shotgun
{
    partial class Form1
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkott = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSkottDator = new System.Windows.Forms.TextBox();
            this.pictureBoxReloadPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxReloadComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxShootingComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxShootingPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlockedPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlockedComputer = new System.Windows.Forms.PictureBox();
            this.pictureBoxShotgunPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxShotgunComputer = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReloadPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReloadComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootingComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootingPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlockedPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlockedComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShotgunPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShotgunComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(56, 539);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(215, 69);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Ladda";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(289, 539);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(215, 69);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Skjut";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(528, 539);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(215, 69);
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(762, 539);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(215, 69);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun!";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(72, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Antal Skott:";
            // 
            // txtSkott
            // 
            this.txtSkott.Location = new System.Drawing.Point(158, 207);
            this.txtSkott.Name = "txtSkott";
            this.txtSkott.Size = new System.Drawing.Size(73, 20);
            this.txtSkott.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(751, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antal Skott:";
            // 
            // txtSkottDator
            // 
            this.txtSkottDator.Location = new System.Drawing.Point(837, 203);
            this.txtSkottDator.Name = "txtSkottDator";
            this.txtSkottDator.Size = new System.Drawing.Size(59, 20);
            this.txtSkottDator.TabIndex = 8;
            // 
            // pictureBoxReloadPlayer
            // 
            this.pictureBoxReloadPlayer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.relod;
            this.pictureBoxReloadPlayer.Location = new System.Drawing.Point(121, 109);
            this.pictureBoxReloadPlayer.Name = "pictureBoxReloadPlayer";
            this.pictureBoxReloadPlayer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxReloadPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReloadPlayer.TabIndex = 10;
            this.pictureBoxReloadPlayer.TabStop = false;
            // 
            // pictureBoxReloadComputer
            // 
            this.pictureBoxReloadComputer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.relod;
            this.pictureBoxReloadComputer.Location = new System.Drawing.Point(786, 106);
            this.pictureBoxReloadComputer.Name = "pictureBoxReloadComputer";
            this.pictureBoxReloadComputer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxReloadComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReloadComputer.TabIndex = 11;
            this.pictureBoxReloadComputer.TabStop = false;
            // 
            // pictureBoxShootingComputer
            // 
            this.pictureBoxShootingComputer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.pistol_shooting;
            this.pictureBoxShootingComputer.Location = new System.Drawing.Point(786, 106);
            this.pictureBoxShootingComputer.Name = "pictureBoxShootingComputer";
            this.pictureBoxShootingComputer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxShootingComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShootingComputer.TabIndex = 12;
            this.pictureBoxShootingComputer.TabStop = false;
            // 
            // pictureBoxShootingPlayer
            // 
            this.pictureBoxShootingPlayer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.pistol_shooting;
            this.pictureBoxShootingPlayer.Location = new System.Drawing.Point(121, 106);
            this.pictureBoxShootingPlayer.Name = "pictureBoxShootingPlayer";
            this.pictureBoxShootingPlayer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxShootingPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShootingPlayer.TabIndex = 13;
            this.pictureBoxShootingPlayer.TabStop = false;
            // 
            // pictureBoxBlockedPlayer
            // 
            this.pictureBoxBlockedPlayer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.blocked;
            this.pictureBoxBlockedPlayer.Location = new System.Drawing.Point(121, 106);
            this.pictureBoxBlockedPlayer.Name = "pictureBoxBlockedPlayer";
            this.pictureBoxBlockedPlayer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxBlockedPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlockedPlayer.TabIndex = 14;
            this.pictureBoxBlockedPlayer.TabStop = false;
            // 
            // pictureBoxBlockedComputer
            // 
            this.pictureBoxBlockedComputer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.blocked;
            this.pictureBoxBlockedComputer.Location = new System.Drawing.Point(786, 106);
            this.pictureBoxBlockedComputer.Name = "pictureBoxBlockedComputer";
            this.pictureBoxBlockedComputer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxBlockedComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlockedComputer.TabIndex = 15;
            this.pictureBoxBlockedComputer.TabStop = false;
            // 
            // pictureBoxShotgunPlayer
            // 
            this.pictureBoxShotgunPlayer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.shotgun_fire;
            this.pictureBoxShotgunPlayer.Location = new System.Drawing.Point(121, 106);
            this.pictureBoxShotgunPlayer.Name = "pictureBoxShotgunPlayer";
            this.pictureBoxShotgunPlayer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxShotgunPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShotgunPlayer.TabIndex = 16;
            this.pictureBoxShotgunPlayer.TabStop = false;
            // 
            // pictureBoxShotgunComputer
            // 
            this.pictureBoxShotgunComputer.Image = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.shotgun_fire;
            this.pictureBoxShotgunComputer.Location = new System.Drawing.Point(786, 106);
            this.pictureBoxShotgunComputer.Name = "pictureBoxShotgunComputer";
            this.pictureBoxShotgunComputer.Size = new System.Drawing.Size(110, 83);
            this.pictureBoxShotgunComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShotgunComputer.TabIndex = 17;
            this.pictureBoxShotgunComputer.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(422, 471);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(35, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(914, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Computer";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(400, 194);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(93, 44);
            this.btnPlayAgain.TabIndex = 21;
            this.btnPlayAgain.Text = "Kör igen";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(528, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 44);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Avsluta";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblWin.Location = new System.Drawing.Point(448, 165);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(140, 24);
            this.lblWin.TabIndex = 23;
            this.lblWin.Text = "You have Won!";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLost.Location = new System.Drawing.Point(439, 167);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(149, 24);
            this.lblLost.TabIndex = 24;
            this.lblLost.Text = "You have LOST!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inlämningsuppgift_2.Shotgun.Properties.Resources.shotgun_1;
            this.ClientSize = new System.Drawing.Size(1019, 610);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBoxShotgunComputer);
            this.Controls.Add(this.pictureBoxShotgunPlayer);
            this.Controls.Add(this.pictureBoxBlockedComputer);
            this.Controls.Add(this.pictureBoxBlockedPlayer);
            this.Controls.Add(this.pictureBoxShootingPlayer);
            this.Controls.Add(this.pictureBoxShootingComputer);
            this.Controls.Add(this.pictureBoxReloadComputer);
            this.Controls.Add(this.pictureBoxReloadPlayer);
            this.Controls.Add(this.txtSkottDator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSkott);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnReload);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReloadPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReloadComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootingComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShootingPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlockedPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlockedComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShotgunPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShotgunComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkott;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSkottDator;
        private System.Windows.Forms.PictureBox pictureBoxReloadPlayer;
        private System.Windows.Forms.PictureBox pictureBoxReloadComputer;
        private System.Windows.Forms.PictureBox pictureBoxShootingComputer;
        private System.Windows.Forms.PictureBox pictureBoxShootingPlayer;
        private System.Windows.Forms.PictureBox pictureBoxBlockedPlayer;
        private System.Windows.Forms.PictureBox pictureBoxBlockedComputer;
        private System.Windows.Forms.PictureBox pictureBoxShotgunPlayer;
        private System.Windows.Forms.PictureBox pictureBoxShotgunComputer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLost;
    }
}

