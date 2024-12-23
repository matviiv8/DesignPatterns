namespace Flyweight
{
    public class Car
    {
        private readonly string _owner;
        private readonly string _licensePlate;
        private readonly CarType _type;

        public Car(string owner, string licensePlate, CarType type)
        {
            _owner = owner;
            _licensePlate = licensePlate;
            _type = type;
        }

        public void Display()
        {
            _type.Display(_owner, _licensePlate);
        }
    }
}