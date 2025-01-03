namespace PirateApp.Weapons
{
    public class Sword : Weapon
    {
        public float BladeLengthInCm { get; set; }

        public Sword(string type, float bladeLengthInCm) : base(type)
        {
            BladeLengthInCm = bladeLengthInCm;
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