namespace PirateApp
{
    public interface IMovable
    {
        float DefaultSpeedKmh { get; }
        void MoveForward(int speed);
        void MoveBackward(int speed);
    }
}