namespace Inlämningsuppgift_2.Shotgun
{
    public class PlayerInfo
    {        
        public int AmountBullets { get; set; }
        public bool ShotGun { get; set; }
        public ShotgunEnum ActiveChoice { get; set; }   
        public bool WonGame {  get; set; } = false;
        public void ReloadAmmuntion()
        {
            AmountBullets++;   
        }
        public void LoseAmmunition()
        {
            AmountBullets--;
        }
        public void Reset()
        {
            AmountBullets = 0;
            ActiveChoice = ShotgunEnum.None;
            WonGame = false;
            ShotGun = false;
        }

    }

    
}
