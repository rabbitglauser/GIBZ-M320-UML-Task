namespace PirateApp
{
    public class Ship : IMovable
    {
        public int MastCount { get; set; }

        public Ship(int mastCount)
        {
            MastCount = mastCount;
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