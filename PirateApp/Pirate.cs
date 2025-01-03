using System;
using PirateApp;

namespace PirateApp
{
    public class Pirate : IMovable
    {
        public string Name { get; set; }
        public bool HasEyePatch { get; set; }
        public DateTime Birthday { get; set; }

        public Pirate(string name, bool hasEyePatch, DateTime birthday)
        {
            Name = name;
            HasEyePatch = hasEyePatch;
            Birthday = birthday;
        }

        public void Swear(string[] swearWords)
        {
            // Implementation for swearing
        }

        public float DefaultSpeedKmh
        {
            get
            {
                // Implementation for default speed
                return 0;
            }
        }

        public void MoveForward(int speed)
        {
            // Implementation for moving forward
        }

        public void MoveBackward(int speed)
        {
            // Implementation for moving backward
        }
    }
}