namespace PirateApp.Weapons
{
    public class Pistol : Weapon
    {
        public float Caliber { get; set; }

        public Pistol(string type, float caliber) : base(type)
        {
            Caliber = caliber;
        }

        public void Shoot(int bulletCount)
        {
            // Implementation for shooting
        }

        public override int GetHazardousness()
        {
            // Implementation for hazardousness
            return 0;
        }

        public override void SetHazardousness(int hazardousness)
        {
            // Implementation for setting hazardousness
        }
    }
}