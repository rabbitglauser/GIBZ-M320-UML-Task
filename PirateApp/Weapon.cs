namespace PirateApp
{
    namespace Weapons
    {
        public abstract class Weapon
        {
            public string Type { get; set; }

            public Weapon(string type)
            {
                Type = type;
            }

            public abstract int GetHazardousness();
            public abstract void SetHazardousness(int hazardousness);
        }
    }
}