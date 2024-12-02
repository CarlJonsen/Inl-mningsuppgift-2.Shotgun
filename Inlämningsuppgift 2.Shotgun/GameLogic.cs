using System;

namespace Inlämningsuppgift_2.Shotgun
{
    public class GameLogic
    {       
      public static void CheckResult(PlayerInfo player, PlayerInfo computer)
      {
            // Player has pressed Reload
            if (player.ActiveChoice == ShotgunEnum.Reload && computer.ActiveChoice == ShotgunEnum.Reload)
            {
                player.ReloadAmmuntion();
                computer.ReloadAmmuntion();
            }
            else if (player.ActiveChoice == ShotgunEnum.Reload && computer.ActiveChoice == ShotgunEnum.BlockBullet) 
            {
                player.ReloadAmmuntion();
            }
            else if(player.ActiveChoice == ShotgunEnum.Reload && computer.ActiveChoice == ShotgunEnum.Shoot)
            {
                computer.WonGame = true;
                player.WonGame = false;
            }
            else if (player.ActiveChoice == ShotgunEnum.Reload && computer.ActiveChoice == ShotgunEnum.Shotgun)
            {
                computer.WonGame = true;
                player.WonGame = false;
            }

            // Player has pressed block
            if (player.ActiveChoice == ShotgunEnum.BlockBullet && computer.ActiveChoice == ShotgunEnum.Reload)
            {                
                computer.ReloadAmmuntion();
            }
            else if (player.ActiveChoice == ShotgunEnum.BlockBullet && computer.ActiveChoice == ShotgunEnum.BlockBullet)
            {
                // Nothing happens
            }
            else if (player.ActiveChoice == ShotgunEnum.BlockBullet && computer.ActiveChoice == ShotgunEnum.Shoot)
            {
                computer.LoseAmmunition();
            }
            else if (player.ActiveChoice == ShotgunEnum.BlockBullet && computer.ActiveChoice == ShotgunEnum.Shotgun)
            {
                computer.WonGame = true;
                player.WonGame = false;
            }


            // Player has pressed shoot
            if (player.ActiveChoice == ShotgunEnum.Shoot && computer.ActiveChoice == ShotgunEnum.Reload)
            {
                 player.WonGame = true;
                 computer.WonGame = false;             
            }
            else if (player.ActiveChoice == ShotgunEnum.Shoot && computer.ActiveChoice == ShotgunEnum.BlockBullet)
            {
                player.LoseAmmunition();
            }
            else if (player.ActiveChoice == ShotgunEnum.Shoot && computer.ActiveChoice == ShotgunEnum.Shoot)
            {
                player.LoseAmmunition();
                computer.LoseAmmunition();
            }
            else if (player.ActiveChoice == ShotgunEnum.Shoot && computer.ActiveChoice == ShotgunEnum.Shotgun)
            {
                computer.WonGame = true;
                player.WonGame = false;
            }

            // Player has pressed shotgun
            if (player.ActiveChoice == ShotgunEnum.Shotgun && computer.ActiveChoice == ShotgunEnum.Reload)
            {
                player.WonGame = true;
                computer.WonGame = false;
            }
            else if (player.ActiveChoice == ShotgunEnum.Shotgun && computer.ActiveChoice == ShotgunEnum.BlockBullet)
            {
                player.WonGame = true;
                computer.WonGame = false;
            }
            else if (player.ActiveChoice == ShotgunEnum.Shotgun && computer.ActiveChoice == ShotgunEnum.Shoot)
            {
                player.WonGame = true;
                computer.WonGame = false;
            }
            else if (player.ActiveChoice == ShotgunEnum.Shotgun && computer.ActiveChoice == ShotgunEnum.Shotgun)
            {
                player.WonGame = false;
                computer.WonGame = false;
                computer.AmountBullets = 0;
                player.AmountBullets = 0;
            }
        }

        public ShotgunEnum ComputersChoice(PlayerInfo computer) // Function for the computer to make a choice.
        {
            bool validChoice = false;
            ShotgunEnum rnd2 = ShotgunEnum.None; // Set rnd2 to something, otherwise it will complain (:

            while (!validChoice)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 4); // Generates a number between 0-3
                rnd2 = (ShotgunEnum)randomNumber;

                if (CanPlayerPerformAction(rnd2, computer)) // Checks that the computer can make its choice. For example, if it wants to use a shotgun, it must have at least 3 bullets.
                {
                    validChoice = true; // Exit loop on valid choice
                }
            }

            return rnd2; // Now guaranteed to return after loop
        }

        public bool CanPlayerPerformAction(ShotgunEnum checkIfOk, PlayerInfo checkSpelare) // Function that checks the player's choices so they can't cheat.
        {
            if (checkIfOk == ShotgunEnum.Reload)
            {
                if (checkSpelare.AmountBullets >= 0 && checkSpelare.AmountBullets < 3)
                {
                    return true;
                }
            }
            if (checkIfOk == ShotgunEnum.Shoot)
            {
                if (checkSpelare.AmountBullets > 0 && checkSpelare.AmountBullets < 4)
                {
                    return true;
                }
            }
            if (checkIfOk == ShotgunEnum.BlockBullet)
            {
                return true;
            }
            if (checkIfOk == ShotgunEnum.Shotgun)
            {
                if (checkSpelare.AmountBullets == 3)
                {
                    return true;
                }
            }
            return false;
        }


    }


}
